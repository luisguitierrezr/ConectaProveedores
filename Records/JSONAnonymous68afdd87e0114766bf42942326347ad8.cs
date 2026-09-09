using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// WizardApprovalDisplayRecord
public class JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 : AbstractRESTStructure<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> {
[JsonProperty("WizardApprovalDisplay")]
[JsonPropertyName("WizardApprovalDisplay")]
public ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure AttrWizardApprovalDisplay;

public JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8() { }

public JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrWizardApprovalDisplay = ConvertToRestWithoutDefaults(s.ssSTWizardApprovalDisplay, new ST_3c480a6d17a69eed60b057b7ed343a1dStructure(), ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure.FromStructure, config);
  } else {
AttrWizardApprovalDisplay = ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure.FromStructure(s.ssSTWizardApprovalDisplay, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8, RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 s) => ToStructure(s, config);
}
public static RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 obj, IBehaviorsConfiguration config) { 
  RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 s = new RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8();
  if(obj != null) {
  s.ssSTWizardApprovalDisplay = ssConectaProveedores.RestRecords.JSONST_3c480a6d17a69eed60b057b7ed343a1dStructure.ToStructure(obj.AttrWizardApprovalDisplay, config);
  }
  return s;
}

public static Func<RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8, ssConectaProveedores.RestRecords.JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 FromStructure(RC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a7c2cd770dc9e2fc3e0bdfd2d99a38b8(s, config);
}

}


