using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_RM_COSMOZ_Request_Struct
public class RESTST_b38fe38940c72474a8e67442651bc995Structure : AbstractRESTStructure<ST_b38fe38940c72474a8e67442651bc995Structure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
public ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
public ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure AttrPI_ITEM_SM;

public RESTST_b38fe38940c72474a8e67442651bc995Structure() { }

public RESTST_b38fe38940c72474a8e67442651bc995Structure (ST_b38fe38940c72474a8e67442651bc995Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssPI_HEADER, new ST_cab398c7a09085084636430b80f5aa0dStructure(), ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure.FromStructure, config);
AttrPI_ITEM_EM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_EM, new ST_9689a124a3af07dbe86be1015d9b7bb1Structure(), ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure.FromStructure, config);
AttrPI_ITEM_SM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_SM, new ST_145adfa176456c38d3985aa98c524483Structure(), ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure.FromStructure(s.ssPI_ITEM_EM, config);
AttrPI_ITEM_SM = ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure.FromStructure(s.ssPI_ITEM_SM, config);
  }
}

public static ST_b38fe38940c72474a8e67442651bc995Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure obj) { 
  ST_b38fe38940c72474a8e67442651bc995Structure s = new ST_b38fe38940c72474a8e67442651bc995Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_cab398c7a09085084636430b80f5aa0dStructure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM_EM = ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure.ToStructure(obj.AttrPI_ITEM_EM);
  s.ssPI_ITEM_SM = ssConectaProveedores.RestRecords.RESTST_145adfa176456c38d3985aa98c524483Structure.ToStructure(obj.AttrPI_ITEM_SM);
  }
  return s;
}

public static Func<ST_b38fe38940c72474a8e67442651bc995Structure, ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b38fe38940c72474a8e67442651bc995Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure FromStructure(ST_b38fe38940c72474a8e67442651bc995Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_b38fe38940c72474a8e67442651bc995Structure(s, config);
}

}


