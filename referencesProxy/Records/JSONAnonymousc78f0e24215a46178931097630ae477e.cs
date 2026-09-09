using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// BusinessValueSubcategoryRecord
public class JSONRC_87a3063e6674014b4b345dce21ff4d84 : AbstractRESTStructure<RC_87a3063e6674014b4b345dce21ff4d84> {
[JsonProperty("BusinessValueSubcategory")]
[JsonPropertyName("BusinessValueSubcategory")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord AttrBusinessValueSubcategory;

public JSONRC_87a3063e6674014b4b345dce21ff4d84() { }

public JSONRC_87a3063e6674014b4b345dce21ff4d84 (RC_87a3063e6674014b4b345dce21ff4d84 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBusinessValueSubcategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueSubcategory, new EN_f296fc330d9916f9de4aae18321e8388EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure, config);
  } else {
AttrBusinessValueSubcategory = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure(s.ssENBusinessValueSubcategory, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_87a3063e6674014b4b345dce21ff4d84, RC_87a3063e6674014b4b345dce21ff4d84> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_87a3063e6674014b4b345dce21ff4d84 s) => ToStructure(s, config);
}
public static RC_87a3063e6674014b4b345dce21ff4d84 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_87a3063e6674014b4b345dce21ff4d84 obj, IBehaviorsConfiguration config) { 
  RC_87a3063e6674014b4b345dce21ff4d84 s = new RC_87a3063e6674014b4b345dce21ff4d84();
  if(obj != null) {
  s.ssENBusinessValueSubcategory = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_f296fc330d9916f9de4aae18321e8388EntityRecord.ToStructure(obj.AttrBusinessValueSubcategory, config);
  }
  return s;
}

public static Func<RC_87a3063e6674014b4b345dce21ff4d84, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_87a3063e6674014b4b345dce21ff4d84> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87a3063e6674014b4b345dce21ff4d84 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_87a3063e6674014b4b345dce21ff4d84 FromStructure(RC_87a3063e6674014b4b345dce21ff4d84 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_87a3063e6674014b4b345dce21ff4d84(s, config);
}

}


