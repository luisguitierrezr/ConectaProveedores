using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_SM_MORecord
public class JSONRC_92d917d40b5023c13ba97b8cae6eddac : AbstractRESTStructure<RC_92d917d40b5023c13ba97b8cae6eddac> {
[JsonProperty("PI_ITEM_SM_MO")]
[JsonPropertyName("PI_ITEM_SM_MO")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure AttrPI_ITEM_SM_MO;

public JSONRC_92d917d40b5023c13ba97b8cae6eddac() { }

public JSONRC_92d917d40b5023c13ba97b8cae6eddac (RC_92d917d40b5023c13ba97b8cae6eddac s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM_MO = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM_MO, new ST_64e1f00088c363cc4d22cb46cb1c9dacStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure.FromStructure, config);
  } else {
AttrPI_ITEM_SM_MO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure.FromStructure(s.ssSTPI_ITEM_SM_MO, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_92d917d40b5023c13ba97b8cae6eddac, RC_92d917d40b5023c13ba97b8cae6eddac> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_92d917d40b5023c13ba97b8cae6eddac s) => ToStructure(s, config);
}
public static RC_92d917d40b5023c13ba97b8cae6eddac ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_92d917d40b5023c13ba97b8cae6eddac obj, IBehaviorsConfiguration config) { 
  RC_92d917d40b5023c13ba97b8cae6eddac s = new RC_92d917d40b5023c13ba97b8cae6eddac();
  if(obj != null) {
  s.ssSTPI_ITEM_SM_MO = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure.ToStructure(obj.AttrPI_ITEM_SM_MO, config);
  }
  return s;
}

public static Func<RC_92d917d40b5023c13ba97b8cae6eddac, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_92d917d40b5023c13ba97b8cae6eddac> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_92d917d40b5023c13ba97b8cae6eddac s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_92d917d40b5023c13ba97b8cae6eddac FromStructure(RC_92d917d40b5023c13ba97b8cae6eddac s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_92d917d40b5023c13ba97b8cae6eddac(s, config);
}

}


