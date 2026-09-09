using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXFFIMF_OBT_TIP_CAMRespRecord
public class JSONRC_aaf77cde47982cd889d3f7caafb8e2be : AbstractRESTStructure<RC_aaf77cde47982cd889d3f7caafb8e2be> {
[JsonProperty("ZMXFFIMF_OBT_TIP_CAMResp")]
[JsonPropertyName("ZMXFFIMF_OBT_TIP_CAMResp")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure AttrZMXFFIMF_OBT_TIP_CAMResp;

public JSONRC_aaf77cde47982cd889d3f7caafb8e2be() { }

public JSONRC_aaf77cde47982cd889d3f7caafb8e2be (RC_aaf77cde47982cd889d3f7caafb8e2be s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_OBT_TIP_CAMResp = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_OBT_TIP_CAMResp, new ST_72813e0dac5e52c872182de62adb7f2bStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure.FromStructure, config);
  } else {
AttrZMXFFIMF_OBT_TIP_CAMResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure.FromStructure(s.ssSTZMXFFIMF_OBT_TIP_CAMResp, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_aaf77cde47982cd889d3f7caafb8e2be, RC_aaf77cde47982cd889d3f7caafb8e2be> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_aaf77cde47982cd889d3f7caafb8e2be s) => ToStructure(s, config);
}
public static RC_aaf77cde47982cd889d3f7caafb8e2be ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_aaf77cde47982cd889d3f7caafb8e2be obj, IBehaviorsConfiguration config) { 
  RC_aaf77cde47982cd889d3f7caafb8e2be s = new RC_aaf77cde47982cd889d3f7caafb8e2be();
  if(obj != null) {
  s.ssSTZMXFFIMF_OBT_TIP_CAMResp = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_72813e0dac5e52c872182de62adb7f2bStructure.ToStructure(obj.AttrZMXFFIMF_OBT_TIP_CAMResp, config);
  }
  return s;
}

public static Func<RC_aaf77cde47982cd889d3f7caafb8e2be, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_aaf77cde47982cd889d3f7caafb8e2be> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_aaf77cde47982cd889d3f7caafb8e2be s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_aaf77cde47982cd889d3f7caafb8e2be FromStructure(RC_aaf77cde47982cd889d3f7caafb8e2be s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_aaf77cde47982cd889d3f7caafb8e2be(s, config);
}

}


