﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BattleTech.BTServicesReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BTServicesReference.IBTWar")]
    public interface IBTWar {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBTWar/Attack", ReplyAction="http://tempuri.org/IBTWar/AttackResponse")]
        int Attack(int attackerAttack, int defenderDefence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBTWar/Attack", ReplyAction="http://tempuri.org/IBTWar/AttackResponse")]
        System.Threading.Tasks.Task<int> AttackAsync(int attackerAttack, int defenderDefence);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBTWarChannel : BattleTech.BTServicesReference.IBTWar, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BTWarClient : System.ServiceModel.ClientBase<BattleTech.BTServicesReference.IBTWar>, BattleTech.BTServicesReference.IBTWar {
        
        public BTWarClient() {
        }
        
        public BTWarClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BTWarClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BTWarClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BTWarClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Attack(int attackerAttack, int defenderDefence) {
            return base.Channel.Attack(attackerAttack, defenderDefence);
        }
        
        public System.Threading.Tasks.Task<int> AttackAsync(int attackerAttack, int defenderDefence) {
            return base.Channel.AttackAsync(attackerAttack, defenderDefence);
        }
    }
}
