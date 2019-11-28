using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TimeForCoffee.Tests.Feature.Models;

namespace TimeForCoffee.Tests.Feature.Transforms
{
    [Binding]
    public class LogicAppEventsTransform
    {
        [StepArgumentTransformation]
        public IList<LogicAppEvent> TransformTableToLogicAppEvents(Table table) =>
            table.CreateSet<LogicAppEvent>().ToList();
    }
}
