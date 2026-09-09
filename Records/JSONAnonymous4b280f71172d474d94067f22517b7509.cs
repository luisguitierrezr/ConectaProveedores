using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAllFilesRecord
public class JSONRC_d66b0b09097e5f0bc1ec31076e9aa762 : AbstractRESTStructure<RC_d66b0b09097e5f0bc1ec31076e9aa762> {
[JsonProperty("Requisition")]
[JsonPropertyName("Requisition")]
public ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("AllFiles")]
[JsonPropertyName("AllFiles")]
public ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure[] AttrAllFiles;

public JSONRC_d66b0b09097e5f0bc1ec31076e9aa762() { }

public JSONRC_d66b0b09097e5f0bc1ec31076e9aa762 (RC_d66b0b09097e5f0bc1ec31076e9aa762 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrAllFiles = s.ssRLAllFiles.Length == 0 ? null : s.ssRLAllFiles.ToArray<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrAllFiles = s.ssRLAllFiles.ToArray<ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d66b0b09097e5f0bc1ec31076e9aa762, RC_d66b0b09097e5f0bc1ec31076e9aa762> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d66b0b09097e5f0bc1ec31076e9aa762 s) => ToStructure(s, config);
}
public static RC_d66b0b09097e5f0bc1ec31076e9aa762 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d66b0b09097e5f0bc1ec31076e9aa762 obj, IBehaviorsConfiguration config) { 
  RC_d66b0b09097e5f0bc1ec31076e9aa762 s = new RC_d66b0b09097e5f0bc1ec31076e9aa762();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.JSONEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition, config);
  s.ssRLAllFiles = RL_7a479a555821b093171c5d3cd3382006.ToList(obj.AttrAllFiles, ssConectaProveedores.RestRecords.JSONST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<RC_d66b0b09097e5f0bc1ec31076e9aa762, ssConectaProveedores.RestRecords.JSONRC_d66b0b09097e5f0bc1ec31076e9aa762> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d66b0b09097e5f0bc1ec31076e9aa762 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d66b0b09097e5f0bc1ec31076e9aa762 FromStructure(RC_d66b0b09097e5f0bc1ec31076e9aa762 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d66b0b09097e5f0bc1ec31076e9aa762(s, config);
}

}


