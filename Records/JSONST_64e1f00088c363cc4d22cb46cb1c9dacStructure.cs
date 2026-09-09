using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM_MO
public class JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure : AbstractRESTStructure<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure> {
[JsonProperty("item")]
[JsonPropertyName("item")]
public ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure[] AttrItem;

public JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure() { }

public JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToArray<ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure>(ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToArray<ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure>(ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure, ST_64e1f00088c363cc4d22cb46cb1c9dacStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure s) => ToStructure(s, config);
}
public static ST_64e1f00088c363cc4d22cb46cb1c9dacStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure obj, IBehaviorsConfiguration config) { 
  ST_64e1f00088c363cc4d22cb46cb1c9dacStructure s = new ST_64e1f00088c363cc4d22cb46cb1c9dacStructure();
  if(obj != null) {
  s.ssItem = RL_3bcfc0997e979683ea6eaec348a88df0.ToList(obj.AttrItem, ssConectaProveedores.RestRecords.JSONST_67da2825930e4cc01dda17107c43d1e6Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_64e1f00088c363cc4d22cb46cb1c9dacStructure, ssConectaProveedores.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_64e1f00088c363cc4d22cb46cb1c9dacStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure FromStructure(ST_64e1f00088c363cc4d22cb46cb1c9dacStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_64e1f00088c363cc4d22cb46cb1c9dacStructure(s, config);
}

}


