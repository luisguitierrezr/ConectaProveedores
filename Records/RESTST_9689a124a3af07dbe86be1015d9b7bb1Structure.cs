using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM_RM
public class RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure : AbstractRESTStructure<ST_9689a124a3af07dbe86be1015d9b7bb1Structure> {
[JsonProperty("Item")]
public RestList<ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure> AttrItem;

public RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure() { }

public RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure (ST_9689a124a3af07dbe86be1015d9b7bb1Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItem = s.ssItem.Length == 0 ? null : s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure>(ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure.FromStructureDelegate(config));
  } else {
AttrItem = s.ssItem.ToRestList<ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure>(ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure.FromStructureDelegate(config));
  }
}

public static ST_9689a124a3af07dbe86be1015d9b7bb1Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure obj) { 
  ST_9689a124a3af07dbe86be1015d9b7bb1Structure s = new ST_9689a124a3af07dbe86be1015d9b7bb1Structure();
  if(obj != null) {
  s.ssItem = RL_14f7fedf363c5e2bd9b617b5d8baba14.FromRestList(obj.AttrItem, ssConectaProveedores.RestRecords.RESTST_121fe028e1d357d74e80a524b7b1ba16Structure.ToStructure);
  }
  return s;
}

public static Func<ST_9689a124a3af07dbe86be1015d9b7bb1Structure, ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9689a124a3af07dbe86be1015d9b7bb1Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure FromStructure(ST_9689a124a3af07dbe86be1015d9b7bb1Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_9689a124a3af07dbe86be1015d9b7bb1Structure(s, config);
}

}


