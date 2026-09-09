using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PurchasingGroupRecord
public class JSONRC_786a35d6d77ea6f67817eb0f3988b828 : AbstractRESTStructure<RC_786a35d6d77ea6f67817eb0f3988b828> {
[JsonProperty("PurchasingGroup")]
[JsonPropertyName("PurchasingGroup")]
public ssConectaProveedores.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord AttrPurchasingGroup;

public JSONRC_786a35d6d77ea6f67817eb0f3988b828() { }

public JSONRC_786a35d6d77ea6f67817eb0f3988b828 (RC_786a35d6d77ea6f67817eb0f3988b828 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPurchasingGroup = ConvertToRestWithoutDefaults(s.ssENPurchasingGroup, new EN_ee7b70c961cd5373a4bb51187762126fEntityRecord(), ssConectaProveedores.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord.FromStructure, config);
  } else {
AttrPurchasingGroup = ssConectaProveedores.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord.FromStructure(s.ssENPurchasingGroup, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_786a35d6d77ea6f67817eb0f3988b828, RC_786a35d6d77ea6f67817eb0f3988b828> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_786a35d6d77ea6f67817eb0f3988b828 s) => ToStructure(s, config);
}
public static RC_786a35d6d77ea6f67817eb0f3988b828 ToStructure(ssConectaProveedores.RestRecords.JSONRC_786a35d6d77ea6f67817eb0f3988b828 obj, IBehaviorsConfiguration config) { 
  RC_786a35d6d77ea6f67817eb0f3988b828 s = new RC_786a35d6d77ea6f67817eb0f3988b828();
  if(obj != null) {
  s.ssENPurchasingGroup = ssConectaProveedores.RestRecords.JSONEN_ee7b70c961cd5373a4bb51187762126fEntityRecord.ToStructure(obj.AttrPurchasingGroup, config);
  }
  return s;
}

public static Func<RC_786a35d6d77ea6f67817eb0f3988b828, ssConectaProveedores.RestRecords.JSONRC_786a35d6d77ea6f67817eb0f3988b828> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_786a35d6d77ea6f67817eb0f3988b828 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_786a35d6d77ea6f67817eb0f3988b828 FromStructure(RC_786a35d6d77ea6f67817eb0f3988b828 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_786a35d6d77ea6f67817eb0f3988b828(s, config);
}

}


