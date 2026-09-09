using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAccountingRecord
public class RESTRC_5860726e4142bb2973b9ba88d317465f : AbstractRESTStructure<RC_5860726e4142bb2973b9ba88d317465f> {
[JsonProperty("RequisitionAccounting")]
public ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord AttrRequisitionAccounting;

public RESTRC_5860726e4142bb2973b9ba88d317465f() { }

public RESTRC_5860726e4142bb2973b9ba88d317465f (RC_5860726e4142bb2973b9ba88d317465f s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisitionAccounting = ConvertToRestWithoutDefaults(s.ssENRequisitionAccounting, new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure, config);
  } else {
AttrRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.FromStructure(s.ssENRequisitionAccounting, config);
  }
}

public static RC_5860726e4142bb2973b9ba88d317465f ToStructure(ssConectaProveedores.RestRecords.RESTRC_5860726e4142bb2973b9ba88d317465f obj) { 
  RC_5860726e4142bb2973b9ba88d317465f s = new RC_5860726e4142bb2973b9ba88d317465f();
  if(obj != null) {
  s.ssENRequisitionAccounting = ssConectaProveedores.RestRecords.RESTEN_3554712eb61e9f0a2132c551df0f1db5EntityRecord.ToStructure(obj.AttrRequisitionAccounting);
  }
  return s;
}

public static Func<RC_5860726e4142bb2973b9ba88d317465f, ssConectaProveedores.RestRecords.RESTRC_5860726e4142bb2973b9ba88d317465f> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5860726e4142bb2973b9ba88d317465f s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5860726e4142bb2973b9ba88d317465f FromStructure(RC_5860726e4142bb2973b9ba88d317465f s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5860726e4142bb2973b9ba88d317465f(s, config);
}

}


