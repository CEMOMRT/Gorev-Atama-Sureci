using Bimser.CSP.Workflow.Api.Base;
using Bimser.CSP.Workflow.Api.Steps;
using Bimser.Synergy.Entities.Workflow.Attributes;
using Bimser.Synergy.Entities.Workflow.Interface.Runtime;

namespace stj1_gorev_atama_sureci.Flows
{
    [WorkflowIdentifier("6516584c-45ac-4591-93e1-77e57da92b7b")]
    public partial class Flow1 : WorkflowCode
    {   
        #region [lazy load workflow object fields]

        private FlowStart _flowStart1;
		private FlowEnd _flowEnd1;
		private FlowPosition _secilenKullanici;
		private FlowPosition _amir;
		private FlowAssign _atamaGorev;
		private FlowAssign _akisAmir;
		private FlowCompare _compare1;
		private Variable _variable1;
		private Variable _yuzdeGorev;
		private FlowDocument _gorevAtama;


        #endregion

        #region [lazy load workflow object properties]

        private FlowStart FlowStart1 => _flowStart1 ??= new FlowStart("FlowStart1", _workflowData, this);
		private FlowEnd FlowEnd1 => _flowEnd1 ??= new FlowEnd("FlowEnd1", _workflowData, this);
		private FlowPosition secilenKullanici => _secilenKullanici ??= new FlowPosition("secilenKullanici", _workflowData, this);
		private FlowPosition amir => _amir ??= new FlowPosition("amir", _workflowData, this);
		private FlowAssign atamaGorev => _atamaGorev ??= new FlowAssign("atamaGorev", _workflowData, this);
		private FlowAssign akisAmir => _akisAmir ??= new FlowAssign("akisAmir", _workflowData, this);
		private FlowCompare Compare1 => _compare1 ??= new FlowCompare("Compare1", _workflowData, this);
		private Variable Variable1 => _variable1 ??= new Variable("Variable1", _workflowData, this);
		private Variable yuzdeGorev => _yuzdeGorev ??= new Variable("yuzdeGorev", _workflowData, this);
		private FlowDocument gorevAtama => _gorevAtama ??= new FlowDocument("gorevAtama", _workflowData, this);


        #endregion

        #region [ctor]        

        public Flow1() : this(null)
        {
            
        }
        
        public Flow1(IRuntimeWorkflowData workflowData) : base(workflowData)
        {
            
        }

        #endregion
    }
}