using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// PI_ITEM_SM_CECO
public class JSONST_1241dbde99de907a27732884f6e65ab4Structure : AbstractRESTStructure<ST_1241dbde99de907a27732884f6e65ab4Structure> {
[JsonProperty("item")]
[JsonPropertyName("item")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure[] AttrItem;

public JSONST_1241dbde99de907a27732884f6e65ab4Structure() { }

public JSONST_1241dbde99de907a27732884f6e65ab4Structure (ST_1241dbde99de907a27732884f6e65ab4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToArray<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure>(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure, ST_1241dbde99de907a27732884f6e65ab4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure s) => ToStructure(s, config);
}
public static ST_1241dbde99de907a27732884f6e65ab4Structure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure obj, IBehaviorsConfiguration config) { 
  ST_1241dbde99de907a27732884f6e65ab4Structure s = new ST_1241dbde99de907a27732884f6e65ab4Structure();
  if(obj != null) {
  s.ssItem = RL_58f0d660c2772ea329be34fddf4b9ec9.ToList(obj.AttrItem, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_ab77394b00ae0f5875687584d175cf59Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_1241dbde99de907a27732884f6e65ab4Structure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1241dbde99de907a27732884f6e65ab4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure FromStructure(ST_1241dbde99de907a27732884f6e65ab4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1241dbde99de907a27732884f6e65ab4Structure(s, config);
}

}


