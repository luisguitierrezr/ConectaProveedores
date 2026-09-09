using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDistributionImportStrucRecord
public class RESTRC_0e8dad36985178676a96cdacdf6f5259 : AbstractRESTStructure<RC_0e8dad36985178676a96cdacdf6f5259> {
[JsonProperty("OrderDistributionImportStruc")]
public ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure AttrOrderDistributionImportStruc;

public RESTRC_0e8dad36985178676a96cdacdf6f5259() { }

public RESTRC_0e8dad36985178676a96cdacdf6f5259 (RC_0e8dad36985178676a96cdacdf6f5259 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDistributionImportStruc = ConvertToRestWithoutDefaults(s.ssSTOrderDistributionImportStruc, new ST_eeea109a56651eacd7e36d2408b5b781Structure(), ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure.FromStructure, config);
  } else {
AttrOrderDistributionImportStruc = ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure.FromStructure(s.ssSTOrderDistributionImportStruc, config);
  }
}

public static RC_0e8dad36985178676a96cdacdf6f5259 ToStructure(ssConectaProveedores.RestRecords.RESTRC_0e8dad36985178676a96cdacdf6f5259 obj) { 
  RC_0e8dad36985178676a96cdacdf6f5259 s = new RC_0e8dad36985178676a96cdacdf6f5259();
  if(obj != null) {
  s.ssSTOrderDistributionImportStruc = ssConectaProveedores.RestRecords.RESTST_eeea109a56651eacd7e36d2408b5b781Structure.ToStructure(obj.AttrOrderDistributionImportStruc);
  }
  return s;
}

public static Func<RC_0e8dad36985178676a96cdacdf6f5259, ssConectaProveedores.RestRecords.RESTRC_0e8dad36985178676a96cdacdf6f5259> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0e8dad36985178676a96cdacdf6f5259 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0e8dad36985178676a96cdacdf6f5259 FromStructure(RC_0e8dad36985178676a96cdacdf6f5259 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0e8dad36985178676a96cdacdf6f5259(s, config);
}

}


