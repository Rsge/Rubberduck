using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rubberduck.Inspections.Concrete;
using Rubberduck.Parsing.Inspections.Resources;
using Rubberduck.Parsing.VBA;
using Rubberduck.VBEditor.SafeComWrappers;
using RubberduckTests.Mocks;

namespace RubberduckTests.Inspections
{
    [TestClass]
    public class WriteOnlyPropertyInspectionTests
    {
        [TestMethod]
        [TestCategory("Inspections")]
        public void WriteOnlyProperty_ReturnsResult_Let()
        {
            const string inputCode =
@"Property Let Foo(value)
End Property";

            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("VBAProject", ProjectProtection.Unprotected)
                .AddComponent("MyClass", ComponentType.ClassModule, inputCode)
                .Build();
            var vbe = builder.AddProject(project).Build();

            var parser = MockParser.Create(vbe.Object);

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var inspection = new WriteOnlyPropertyInspection(parser.State);
            var inspectionResults = inspection.GetInspectionResults();

            Assert.AreEqual(1, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void WriteOnlyProperty_ReturnsResult_Set()
        {
            const string inputCode =
@"Property Set Foo(value)
End Property";

            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("VBAProject", ProjectProtection.Unprotected)
                .AddComponent("MyClass", ComponentType.ClassModule, inputCode)
                .Build();
            var vbe = builder.AddProject(project).Build();

            var parser = MockParser.Create(vbe.Object);

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var inspection = new WriteOnlyPropertyInspection(parser.State);
            var inspectionResults = inspection.GetInspectionResults();

            Assert.AreEqual(1, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void WriteOnlyProperty_ReturnsResult_LetAndSet()
        {
            const string inputCode =
@"Property Let Foo(value)
End Property

Property Set Foo(value)
End Property";

            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("VBAProject", ProjectProtection.Unprotected)
                .AddComponent("MyClass", ComponentType.ClassModule, inputCode)
                .Build();
            var vbe = builder.AddProject(project).Build();

            var parser = MockParser.Create(vbe.Object);

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var inspection = new WriteOnlyPropertyInspection(parser.State);
            var inspectionResults = inspection.GetInspectionResults();

            Assert.AreEqual(2, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void WriteOnlyProperty_DoesNotReturnsResult_Get()
        {
            const string inputCode =
@"Property Get Foo()
End Property";

            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("VBAProject", ProjectProtection.Unprotected)
                .AddComponent("MyClass", ComponentType.ClassModule, inputCode)
                .Build();
            var vbe = builder.AddProject(project).Build();

            var parser = MockParser.Create(vbe.Object);

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var inspection = new WriteOnlyPropertyInspection(parser.State);
            var inspectionResults = inspection.GetInspectionResults();

            Assert.IsFalse(inspectionResults.Any());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void WriteOnlyProperty_DoesNotReturnsResult_GetAndLetAndSet()
        {
            const string inputCode =
@"Property Get Foo()
End Property

Property Let Foo(value)
End Property

Property Set Foo(value)
End Property";

            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("VBAProject", ProjectProtection.Unprotected)
                .AddComponent("MyClass", ComponentType.ClassModule, inputCode)
                .Build();
            var vbe = builder.AddProject(project).Build();

            var parser = MockParser.Create(vbe.Object);

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var inspection = new WriteOnlyPropertyInspection(parser.State);
            var inspectionResults = inspection.GetInspectionResults();

            Assert.IsFalse(inspectionResults.Any());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void WriteOnlyProperty_Ignored_DoesNotReturnResult()
        {
            const string inputCode =
@"'@Ignore WriteOnlyProperty
Property Let Foo(value)
End Property";

            var builder = new MockVbeBuilder();
            var project = builder.ProjectBuilder("VBAProject", ProjectProtection.Unprotected)
                .AddComponent("MyClass", ComponentType.ClassModule, inputCode)
                .Build();
            var vbe = builder.AddProject(project).Build();

            var parser = MockParser.Create(vbe.Object);

            parser.Parse(new CancellationTokenSource());
            if (parser.State.Status >= ParserState.Error) { Assert.Inconclusive("Parser Error"); }

            var inspection = new WriteOnlyPropertyInspection(parser.State);
            var inspectionResults = inspection.GetInspectionResults();

            Assert.IsFalse(inspectionResults.Any());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void InspectionType()
        {
            var inspection = new WriteOnlyPropertyInspection(null);
            Assert.AreEqual(CodeInspectionType.CodeQualityIssues, inspection.InspectionType);
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void InspectionName()
        {
            const string inspectionName = "WriteOnlyPropertyInspection";
            var inspection = new WriteOnlyPropertyInspection(null);

            Assert.AreEqual(inspectionName, inspection.Name);
        }
    }
}