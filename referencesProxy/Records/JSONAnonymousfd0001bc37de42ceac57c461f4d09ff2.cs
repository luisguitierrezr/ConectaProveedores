using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// ZMXMIMMF_EM_SM_MO_COSMOZREqRecord
public class JSONRC_ae943cb2defc9034e3c3c726ea9742f4 : AbstractRESTStructure<RC_ae943cb2defc9034e3c3c726ea9742f4> {
[JsonProperty("ZMXMIMMF_EM_SM_MO_COSMOZREq")]
[JsonPropertyName("ZMXMIMMF_EM_SM_MO_COSMOZREq")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure AttrZMXMIMMF_EM_SM_MO_COSMOZREq;

public JSONRC_ae943cb2defc9034e3c3c726ea9742f4() { }

public JSONRC_ae943cb2defc9034e3c3c726ea9742f4 (RC_ae943cb2defc9034e3c3c726ea9742f4 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_EM_SM_MO_COSMOZREq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq, new ST_0d774220c0b1db165444568fabc9b253Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_EM_SM_MO_COSMOZREq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure.FromStructure(s.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ae943cb2defc9034e3c3c726ea9742f4, RC_ae943cb2defc9034e3c3c726ea9742f4> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ae943cb2defc9034e3c3c726ea9742f4 s) => ToStructure(s, config);
}
public static RC_ae943cb2defc9034e3c3c726ea9742f4 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ae943cb2defc9034e3c3c726ea9742f4 obj, IBehaviorsConfiguration config) { 
  RC_ae943cb2defc9034e3c3c726ea9742f4 s = new RC_ae943cb2defc9034e3c3c726ea9742f4();
  if(obj != null) {
  s.ssSTZMXMIMMF_EM_SM_MO_COSMOZREq = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_0d774220c0b1db165444568fabc9b253Structure.ToStructure(obj.AttrZMXMIMMF_EM_SM_MO_COSMOZREq, config);
  }
  return s;
}

public static Func<RC_ae943cb2defc9034e3c3c726ea9742f4, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ae943cb2defc9034e3c3c726ea9742f4> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ae943cb2defc9034e3c3c726ea9742f4 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ae943cb2defc9034e3c3c726ea9742f4 FromStructure(RC_ae943cb2defc9034e3c3c726ea9742f4 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ae943cb2defc9034e3c3c726ea9742f4(s, config);
}

}


