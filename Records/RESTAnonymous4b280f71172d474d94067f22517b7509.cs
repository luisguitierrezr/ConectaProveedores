using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// RequisitionAllFilesRecord
public class RESTRC_d66b0b09097e5f0bc1ec31076e9aa762 : AbstractRESTStructure<RC_d66b0b09097e5f0bc1ec31076e9aa762> {
[JsonProperty("Requisition")]
public ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord AttrRequisition;

[JsonProperty("AllFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure> AttrAllFiles;

public RESTRC_d66b0b09097e5f0bc1ec31076e9aa762() { }

public RESTRC_d66b0b09097e5f0bc1ec31076e9aa762 (RC_d66b0b09097e5f0bc1ec31076e9aa762 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrRequisition = ConvertToRestWithoutDefaults(s.ssENRequisition, new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure, config);
AttrAllFiles = s.ssRLAllFiles.Length == 0 ? null : s.ssRLAllFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
  } else {
AttrRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.FromStructure(s.ssENRequisition, config);
AttrAllFiles = s.ssRLAllFiles.ToRestList<ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure>(ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.FromStructureDelegate(config));
  }
}

public static RC_d66b0b09097e5f0bc1ec31076e9aa762 ToStructure(ssConectaProveedores.RestRecords.RESTRC_d66b0b09097e5f0bc1ec31076e9aa762 obj) { 
  RC_d66b0b09097e5f0bc1ec31076e9aa762 s = new RC_d66b0b09097e5f0bc1ec31076e9aa762();
  if(obj != null) {
  s.ssENRequisition = ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord.ToStructure(obj.AttrRequisition);
  s.ssRLAllFiles = RL_7a479a555821b093171c5d3cd3382006.FromRestList(obj.AttrAllFiles, ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructure);
  }
  return s;
}

public static Func<RC_d66b0b09097e5f0bc1ec31076e9aa762, ssConectaProveedores.RestRecords.RESTRC_d66b0b09097e5f0bc1ec31076e9aa762> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d66b0b09097e5f0bc1ec31076e9aa762 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d66b0b09097e5f0bc1ec31076e9aa762 FromStructure(RC_d66b0b09097e5f0bc1ec31076e9aa762 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d66b0b09097e5f0bc1ec31076e9aa762(s, config);
}

}


