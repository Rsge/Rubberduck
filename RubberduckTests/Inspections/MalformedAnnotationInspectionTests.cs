using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RubberduckTests.Mocks;
using System.Threading;
using Rubberduck.Inspections.Concrete;
using Rubberduck.Parsing.Inspections.Resources;

namespace RubberduckTests.Inspections
{
    [TestClass]
    public class MalformedAnnotationInspectionTests
    {
        [TestMethod]
        [TestCategory("Inspections")]
        public void MalformedAnnotation_ReturnsResult_Folder()
        {
            const string inputCode =
@"'@Folder";

            var vbe = MockVbeBuilder.BuildFromSingleStandardModule(inputCode, out _);
            var state = MockParser.CreateAndParse(vbe.Object);

            var inspection = new MissingAnnotationArgumentInspection(state);
            var inspector = InspectionsHelper.GetInspector(inspection);
            var inspectionResults = inspector.FindIssuesAsync(state, CancellationToken.None).Result;

            Assert.AreEqual(1, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void MalformedAnnotation_DoesNotReturnResult_Folder()
        {
            const string inputCode =
@"'@Folder ""Foo""";

            var vbe = MockVbeBuilder.BuildFromSingleStandardModule(inputCode, out _);
            var state = MockParser.CreateAndParse(vbe.Object);

            var inspection = new MissingAnnotationArgumentInspection(state);
            var inspector = InspectionsHelper.GetInspector(inspection);
            var inspectionResults = inspector.FindIssuesAsync(state, CancellationToken.None).Result;

            Assert.AreEqual(0, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void MalformedAnnotation_ReturnsResult_Ignore()
        {
            const string inputCode =
@"'@Ignore";

            var vbe = MockVbeBuilder.BuildFromSingleStandardModule(inputCode, out _);
            var state = MockParser.CreateAndParse(vbe.Object);

            var inspection = new MissingAnnotationArgumentInspection(state);
            var inspector = InspectionsHelper.GetInspector(inspection);
            var inspectionResults = inspector.FindIssuesAsync(state, CancellationToken.None).Result;

            Assert.AreEqual(1, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void MalformedAnnotation_DoesNotReturnResult_Ignore()
        {
            const string inputCode =
@"'@Ignore ProcedureNotUsedInspection";

            var vbe = MockVbeBuilder.BuildFromSingleStandardModule(inputCode, out _);
            var state = MockParser.CreateAndParse(vbe.Object);

            var inspection = new MissingAnnotationArgumentInspection(state);
            var inspector = InspectionsHelper.GetInspector(inspection);
            var inspectionResults = inspector.FindIssuesAsync(state, CancellationToken.None).Result;

            Assert.AreEqual(0, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void MalformedAnnotation_ReturnsMultipleResults()
        {
            const string inputCode =
@"'@Folder
'@Ignore";

            var vbe = MockVbeBuilder.BuildFromSingleStandardModule(inputCode, out _);
            var state = MockParser.CreateAndParse(vbe.Object);

            var inspection = new MissingAnnotationArgumentInspection(state);
            var inspector = InspectionsHelper.GetInspector(inspection);
            var inspectionResults = inspector.FindIssuesAsync(state, CancellationToken.None).Result;

            Assert.AreEqual(2, inspectionResults.Count());
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void InspectionType()
        {
            var inspection = new MissingAnnotationArgumentInspection(null);
            Assert.AreEqual(CodeInspectionType.CodeQualityIssues, inspection.InspectionType);
        }

        [TestMethod]
        [TestCategory("Inspections")]
        public void InspectionName()
        {
            const string inspectionName = "MissingAnnotationArgumentInspection";
            var inspection = new MissingAnnotationArgumentInspection(null);

            Assert.AreEqual(inspectionName, inspection.Name);
        }
    }
}