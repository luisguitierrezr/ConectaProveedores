using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionImportStrucRecord
public class JSONRC_0e8dad36985178676a96cdacdf6f5259 : AbstractRESTStructure<RC_0e8dad36985178676a96cdacdf6f5259> {
[JsonProperty("OrderDistributionImportStruc")]
[JsonPropertyName("OrderDistributionImportStruc")]
public ssConectaProveedores.RestRecords.JSONST_eeea109a56651eacd7e36d2408b5b781Structure AttrOrderDistributionImportStruc;

public JSONRC_0e8dad36985178676a96cdacdf6f5259() { }

public JSONRC_0e8dad36985178676a96cdacdf6f5259 (RC_0e8dad36985178676a96cdacdf6f5259 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDistributionImportStruc = ConvertToRestWithoutDefaults(s.ssSTOrderDistributionImportStruc, new ST_eeea109a56651eacd7e36d2408b5b781Structure(), ssConectaProveedores.RestRecords.JSONST_eeea109a56651eacd7e36d2408b5b781Structure.FromStructure, config);
  } else {
AttrOrderDistributionImportStruc = ssConectaProveedores.RestRecords.JSONST_eeea109a56651eacd7e36d2408b5b781Structure.FromStructure(s.ssSTOrderDistributionImportStruc, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_0e8dad36985178676a96cdacdf6f5259, RC_0e8dad36985178676a96cdacdf6f5259> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_0e8dad36985178676a96cdacdf6f5259 s) => ToStructure(s, config);
}
public static RC_0e8dad36985178676a96cdacdf6f5259 ToStructure(ssConectaProveedores.RestRecords.JSONRC_0e8dad36985178676a96cdacdf6f5259 obj, IBehaviorsConfiguration config) { 
  RC_0e8dad36985178676a96cdacdf6f5259 s = new RC_0e8dad36985178676a96cdacdf6f5259();
  if(obj != null) {
  s.ssSTOrderDistributionImportStruc = ssConectaProveedores.RestRecords.JSONST_eeea109a56651eacd7e36d2408b5b781Structure.ToStructure(obj.AttrOrderDistributionImportStruc, config);
  }
  return s;
}

public static Func<RC_0e8dad36985178676a96cdacdf6f5259, ssConectaProveedores.RestRecords.JSONRC_0e8dad36985178676a96cdacdf6f5259> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e8dad36985178676a96cdacdf6f5259 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_0e8dad36985178676a96cdacdf6f5259 FromStructure(RC_0e8dad36985178676a96cdacdf6f5259 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_0e8dad36985178676a96cdacdf6f5259(s, config);
}

}


