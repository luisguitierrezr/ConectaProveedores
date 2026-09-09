using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// EM_SM_RM_COSMOZ_Request_Struct
public class JSONST_b38fe38940c72474a8e67442651bc995Structure : AbstractRESTStructure<ST_b38fe38940c72474a8e67442651bc995Structure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
[JsonPropertyName("PI_ITEM_EM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
[JsonPropertyName("PI_ITEM_SM")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure AttrPI_ITEM_SM;

public JSONST_b38fe38940c72474a8e67442651bc995Structure() { }

public JSONST_b38fe38940c72474a8e67442651bc995Structure (ST_b38fe38940c72474a8e67442651bc995Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssPI_HEADER, new ST_cab398c7a09085084636430b80f5aa0dStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure.FromStructure, config);
AttrPI_ITEM_EM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_EM, new ST_9689a124a3af07dbe86be1015d9b7bb1Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure.FromStructure, config);
AttrPI_ITEM_SM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_SM, new ST_145adfa176456c38d3985aa98c524483Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure.FromStructure(s.ssPI_ITEM_EM, config);
AttrPI_ITEM_SM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure.FromStructure(s.ssPI_ITEM_SM, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure, ST_b38fe38940c72474a8e67442651bc995Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure s) => ToStructure(s, config);
}
public static ST_b38fe38940c72474a8e67442651bc995Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure obj, IBehaviorsConfiguration config) { 
  ST_b38fe38940c72474a8e67442651bc995Structure s = new ST_b38fe38940c72474a8e67442651bc995Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_cab398c7a09085084636430b80f5aa0dStructure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM_EM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_9689a124a3af07dbe86be1015d9b7bb1Structure.ToStructure(obj.AttrPI_ITEM_EM, config);
  s.ssPI_ITEM_SM = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_145adfa176456c38d3985aa98c524483Structure.ToStructure(obj.AttrPI_ITEM_SM, config);
  }
  return s;
}

public static Func<ST_b38fe38940c72474a8e67442651bc995Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b38fe38940c72474a8e67442651bc995Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure FromStructure(ST_b38fe38940c72474a8e67442651bc995Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b38fe38940c72474a8e67442651bc995Structure(s, config);
}

}


