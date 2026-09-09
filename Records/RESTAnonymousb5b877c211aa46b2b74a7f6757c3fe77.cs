using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PurchasingGroupRecord
public class RESTRC_786a35d6d77ea6f67817eb0f3988b828 : AbstractRESTStructure<RC_786a35d6d77ea6f67817eb0f3988b828> {
[JsonProperty("PurchasingGroup")]
public ssConectaProveedores.RestRecords.RESTEN_ee7b70c961cd5373a4bb51187762126fEntityRecord AttrPurchasingGroup;

public RESTRC_786a35d6d77ea6f67817eb0f3988b828() { }

public RESTRC_786a35d6d77ea6f67817eb0f3988b828 (RC_786a35d6d77ea6f67817eb0f3988b828 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPurchasingGroup = ConvertToRestWithoutDefaults(s.ssENPurchasingGroup, new EN_ee7b70c961cd5373a4bb51187762126fEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee7b70c961cd5373a4bb51187762126fEntityRecord.FromStructure, config);
  } else {
AttrPurchasingGroup = ssConectaProveedores.RestRecords.RESTEN_ee7b70c961cd5373a4bb51187762126fEntityRecord.FromStructure(s.ssENPurchasingGroup, config);
  }
}

public static RC_786a35d6d77ea6f67817eb0f3988b828 ToStructure(ssConectaProveedores.RestRecords.RESTRC_786a35d6d77ea6f67817eb0f3988b828 obj) { 
  RC_786a35d6d77ea6f67817eb0f3988b828 s = new RC_786a35d6d77ea6f67817eb0f3988b828();
  if(obj != null) {
  s.ssENPurchasingGroup = ssConectaProveedores.RestRecords.RESTEN_ee7b70c961cd5373a4bb51187762126fEntityRecord.ToStructure(obj.AttrPurchasingGroup);
  }
  return s;
}

public static Func<RC_786a35d6d77ea6f67817eb0f3988b828, ssConectaProveedores.RestRecords.RESTRC_786a35d6d77ea6f67817eb0f3988b828> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_786a35d6d77ea6f67817eb0f3988b828 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_786a35d6d77ea6f67817eb0f3988b828 FromStructure(RC_786a35d6d77ea6f67817eb0f3988b828 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_786a35d6d77ea6f67817eb0f3988b828(s, config);
}

}


