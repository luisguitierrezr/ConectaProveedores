using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SpecialApprovalRecord
public class RESTRC_34acf11553964937c377a82c97a2edf5 : AbstractRESTStructure<RC_34acf11553964937c377a82c97a2edf5> {
[JsonProperty("SpecialApproval")]
public ssConectaProveedores.RestRecords.RESTEN_269041044ca0bb6901788ecb5d297c5eEntityRecord AttrSpecialApproval;

public RESTRC_34acf11553964937c377a82c97a2edf5() { }

public RESTRC_34acf11553964937c377a82c97a2edf5 (RC_34acf11553964937c377a82c97a2edf5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSpecialApproval = ConvertToRestWithoutDefaults(s.ssENSpecialApproval, new EN_269041044ca0bb6901788ecb5d297c5eEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_269041044ca0bb6901788ecb5d297c5eEntityRecord.FromStructure, config);
  } else {
AttrSpecialApproval = ssConectaProveedores.RestRecords.RESTEN_269041044ca0bb6901788ecb5d297c5eEntityRecord.FromStructure(s.ssENSpecialApproval, config);
  }
}

public static RC_34acf11553964937c377a82c97a2edf5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5 obj) { 
  RC_34acf11553964937c377a82c97a2edf5 s = new RC_34acf11553964937c377a82c97a2edf5();
  if(obj != null) {
  s.ssENSpecialApproval = ssConectaProveedores.RestRecords.RESTEN_269041044ca0bb6901788ecb5d297c5eEntityRecord.ToStructure(obj.AttrSpecialApproval);
  }
  return s;
}

public static Func<RC_34acf11553964937c377a82c97a2edf5, ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_34acf11553964937c377a82c97a2edf5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5 FromStructure(RC_34acf11553964937c377a82c97a2edf5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5(s, config);
}

}


