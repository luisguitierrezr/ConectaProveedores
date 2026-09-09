using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM_CECO
public class RESTST_1241dbde99de907a27732884f6e65ab4Structure : AbstractRESTStructure<ST_1241dbde99de907a27732884f6e65ab4Structure> {
[JsonProperty("Item")]
public RestList<ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure> AttrItem;

public RESTST_1241dbde99de907a27732884f6e65ab4Structure() { }

public RESTST_1241dbde99de907a27732884f6e65ab4Structure (ST_1241dbde99de907a27732884f6e65ab4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure>(ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure>(ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure.FromStructureDelegate(config));
  }
}

public static ST_1241dbde99de907a27732884f6e65ab4Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure obj) { 
  ST_1241dbde99de907a27732884f6e65ab4Structure s = new ST_1241dbde99de907a27732884f6e65ab4Structure();
  if(obj != null) {
  s.ssItem = RL_58f0d660c2772ea329be34fddf4b9ec9.FromRestList(obj.AttrItem, ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure.ToStructure);
  }
  return s;
}

public static Func<ST_1241dbde99de907a27732884f6e65ab4Structure, ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_1241dbde99de907a27732884f6e65ab4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure FromStructure(ST_1241dbde99de907a27732884f6e65ab4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_1241dbde99de907a27732884f6e65ab4Structure(s, config);
}

}


