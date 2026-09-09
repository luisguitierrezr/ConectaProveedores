using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioObservationsRecord
public class RESTRC_017cba02e4fd7f684606081b7269a26b : AbstractRESTStructure<RC_017cba02e4fd7f684606081b7269a26b> {
[JsonProperty("FolioObservations")]
public ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord AttrFolioObservations;

public RESTRC_017cba02e4fd7f684606081b7269a26b() { }

public RESTRC_017cba02e4fd7f684606081b7269a26b (RC_017cba02e4fd7f684606081b7269a26b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioObservations = ConvertToRestWithoutDefaults(s.ssENFolioObservations, new EN_171b22187ea6e4b12c9f086502740307EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord.FromStructure, config);
  } else {
AttrFolioObservations = ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord.FromStructure(s.ssENFolioObservations, config);
  }
}

public static RC_017cba02e4fd7f684606081b7269a26b ToStructure(ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b obj) { 
  RC_017cba02e4fd7f684606081b7269a26b s = new RC_017cba02e4fd7f684606081b7269a26b();
  if(obj != null) {
  s.ssENFolioObservations = ssConectaProveedores.RestRecords.RESTEN_171b22187ea6e4b12c9f086502740307EntityRecord.ToStructure(obj.AttrFolioObservations);
  }
  return s;
}

public static Func<RC_017cba02e4fd7f684606081b7269a26b, ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_017cba02e4fd7f684606081b7269a26b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b FromStructure(RC_017cba02e4fd7f684606081b7269a26b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_017cba02e4fd7f684606081b7269a26b(s, config);
}

}


