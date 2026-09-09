using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// Quantity_SumRecord
public class RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398 : AbstractRESTStructure<RC_3c0d20260cc8c66bb46ae8f7e84cc398> {
[JsonProperty("Quantity_Sum")]
public decimal? AttrQuantity_Sum;

public RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398() { }

public RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398 (RC_3c0d20260cc8c66bb46ae8f7e84cc398 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrQuantity_Sum = ConvertToRestWithoutDefaults(s.ssQuantity_Sum, 0.0M);
  } else {
AttrQuantity_Sum = (decimal?) s.ssQuantity_Sum;
  }
}

public static RC_3c0d20260cc8c66bb46ae8f7e84cc398 ToStructure(ssConectaProveedores.RestRecords.RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398 obj) { 
  RC_3c0d20260cc8c66bb46ae8f7e84cc398 s = new RC_3c0d20260cc8c66bb46ae8f7e84cc398();
  if(obj != null) {
  s.ssQuantity_Sum = obj.AttrQuantity_Sum == null ? 0.0M : obj.AttrQuantity_Sum.Value;
  }
  return s;
}

public static Func<RC_3c0d20260cc8c66bb46ae8f7e84cc398, ssConectaProveedores.RestRecords.RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_3c0d20260cc8c66bb46ae8f7e84cc398 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398 FromStructure(RC_3c0d20260cc8c66bb46ae8f7e84cc398 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_3c0d20260cc8c66bb46ae8f7e84cc398(s, config);
}

}


