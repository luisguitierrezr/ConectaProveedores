using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_MO_COSMOZ_Request_Struct
public class JSONST_e88e810a3be3c7b278de1b477e897388Structure : AbstractRESTStructure<ST_e88e810a3be3c7b278de1b477e897388Structure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
[JsonPropertyName("PI_ITEM_EM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
[JsonPropertyName("PI_ITEM_SM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure AttrPI_ITEM_SM;

public JSONST_e88e810a3be3c7b278de1b477e897388Structure() { }

public JSONST_e88e810a3be3c7b278de1b477e897388Structure (ST_e88e810a3be3c7b278de1b477e897388Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssPI_HEADER, new ST_16a23b6e422231c222f34612ecd6c640Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure.FromStructure, config);
AttrPI_ITEM_EM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_EM, new ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure.FromStructure, config);
AttrPI_ITEM_SM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_SM, new ST_64e1f00088c363cc4d22cb46cb1c9dacStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure.FromStructure(s.ssPI_ITEM_EM, config);
AttrPI_ITEM_SM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure.FromStructure(s.ssPI_ITEM_SM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure, ST_e88e810a3be3c7b278de1b477e897388Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure s) => ToStructure(s, config);
}
public static ST_e88e810a3be3c7b278de1b477e897388Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure obj, IBehaviorsConfiguration config) { 
  ST_e88e810a3be3c7b278de1b477e897388Structure s = new ST_e88e810a3be3c7b278de1b477e897388Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_16a23b6e422231c222f34612ecd6c640Structure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM_EM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b66fb52d7e61909cfa3b37d2fa32ed69Structure.ToStructure(obj.AttrPI_ITEM_EM, config);
  s.ssPI_ITEM_SM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure.ToStructure(obj.AttrPI_ITEM_SM, config);
  }
  return s;
}

public static Func<ST_e88e810a3be3c7b278de1b477e897388Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_e88e810a3be3c7b278de1b477e897388Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure FromStructure(ST_e88e810a3be3c7b278de1b477e897388Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_e88e810a3be3c7b278de1b477e897388Structure(s, config);
}

}


