using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// EM_SM_CECO_COSMOZ_Request_Struct
public class RESTST_883584831b34399a326748c4b1ce95c9Structure : AbstractRESTStructure<ST_883584831b34399a326748c4b1ce95c9Structure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_b76a29481a19f994f96cb0bc4134fe6dStructure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
public ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
public ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure AttrPI_ITEM_SM;

public RESTST_883584831b34399a326748c4b1ce95c9Structure() { }

public RESTST_883584831b34399a326748c4b1ce95c9Structure (ST_883584831b34399a326748c4b1ce95c9Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ConvertToRestWithoutDefaults(s.ssPI_HEADER, new ST_b76a29481a19f994f96cb0bc4134fe6dStructure(), ssConectaProveedores.RestRecords.RESTST_b76a29481a19f994f96cb0bc4134fe6dStructure.FromStructure, config);
AttrPI_ITEM_EM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_EM, new ST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure(), ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure.FromStructure, config);
AttrPI_ITEM_SM = ConvertToRestWithoutDefaults(s.ssPI_ITEM_SM, new ST_1241dbde99de907a27732884f6e65ab4Structure(), ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure.FromStructure, config);
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_b76a29481a19f994f96cb0bc4134fe6dStructure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure.FromStructure(s.ssPI_ITEM_EM, config);
AttrPI_ITEM_SM = ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure.FromStructure(s.ssPI_ITEM_SM, config);
  }
}

public static ST_883584831b34399a326748c4b1ce95c9Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_883584831b34399a326748c4b1ce95c9Structure obj) { 
  ST_883584831b34399a326748c4b1ce95c9Structure s = new ST_883584831b34399a326748c4b1ce95c9Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_b76a29481a19f994f96cb0bc4134fe6dStructure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM_EM = ssConectaProveedores.RestRecords.RESTST_f6aefb5d1f2e48348e16fc4d9e0699f9Structure.ToStructure(obj.AttrPI_ITEM_EM);
  s.ssPI_ITEM_SM = ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure.ToStructure(obj.AttrPI_ITEM_SM);
  }
  return s;
}

public static Func<ST_883584831b34399a326748c4b1ce95c9Structure, ssConectaProveedores.RestRecords.RESTST_883584831b34399a326748c4b1ce95c9Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_883584831b34399a326748c4b1ce95c9Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_883584831b34399a326748c4b1ce95c9Structure FromStructure(ST_883584831b34399a326748c4b1ce95c9Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_883584831b34399a326748c4b1ce95c9Structure(s, config);
}

}


