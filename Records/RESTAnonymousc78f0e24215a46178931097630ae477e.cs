using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BusinessValueSubcategoryRecord
public class RESTRC_87a3063e6674014b4b345dce21ff4d84 : AbstractRESTStructure<RC_87a3063e6674014b4b345dce21ff4d84> {
[JsonProperty("BusinessValueSubcategory")]
public ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord AttrBusinessValueSubcategory;

public RESTRC_87a3063e6674014b4b345dce21ff4d84() { }

public RESTRC_87a3063e6674014b4b345dce21ff4d84 (RC_87a3063e6674014b4b345dce21ff4d84 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrBusinessValueSubcategory = ConvertToRestWithoutDefaults(s.ssENBusinessValueSubcategory, new EN_f296fc330d9916f9de4aae18321e8388EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure, config);
  } else {
AttrBusinessValueSubcategory = ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord.FromStructure(s.ssENBusinessValueSubcategory, config);
  }
}

public static RC_87a3063e6674014b4b345dce21ff4d84 ToStructure(ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84 obj) { 
  RC_87a3063e6674014b4b345dce21ff4d84 s = new RC_87a3063e6674014b4b345dce21ff4d84();
  if(obj != null) {
  s.ssENBusinessValueSubcategory = ssConectaProveedores.RestRecords.RESTEN_f296fc330d9916f9de4aae18321e8388EntityRecord.ToStructure(obj.AttrBusinessValueSubcategory);
  }
  return s;
}

public static Func<RC_87a3063e6674014b4b345dce21ff4d84, ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_87a3063e6674014b4b345dce21ff4d84 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84 FromStructure(RC_87a3063e6674014b4b345dce21ff4d84 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84(s, config);
}

}


