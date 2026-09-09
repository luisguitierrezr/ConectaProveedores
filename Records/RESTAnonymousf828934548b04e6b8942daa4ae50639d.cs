using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_WXD_OutRecord
public class RESTRC_2fdd8a774a3284e223459de0e7f3cff9 : AbstractRESTStructure<RC_2fdd8a774a3284e223459de0e7f3cff9> {
[JsonProperty("TI_WXD_Out")]
public ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure AttrTI_WXD_Out;

public RESTRC_2fdd8a774a3284e223459de0e7f3cff9() { }

public RESTRC_2fdd8a774a3284e223459de0e7f3cff9 (RC_2fdd8a774a3284e223459de0e7f3cff9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_WXD_Out = ConvertToRestWithoutDefaults(s.ssSTTI_WXD_Out, new ST_646bfb521d5f3e3e304163b436da5220Structure(), ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure.FromStructure, config);
  } else {
AttrTI_WXD_Out = ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure.FromStructure(s.ssSTTI_WXD_Out, config);
  }
}

public static RC_2fdd8a774a3284e223459de0e7f3cff9 ToStructure(ssConectaProveedores.RestRecords.RESTRC_2fdd8a774a3284e223459de0e7f3cff9 obj) { 
  RC_2fdd8a774a3284e223459de0e7f3cff9 s = new RC_2fdd8a774a3284e223459de0e7f3cff9();
  if(obj != null) {
  s.ssSTTI_WXD_Out = ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure.ToStructure(obj.AttrTI_WXD_Out);
  }
  return s;
}

public static Func<RC_2fdd8a774a3284e223459de0e7f3cff9, ssConectaProveedores.RestRecords.RESTRC_2fdd8a774a3284e223459de0e7f3cff9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_2fdd8a774a3284e223459de0e7f3cff9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_2fdd8a774a3284e223459de0e7f3cff9 FromStructure(RC_2fdd8a774a3284e223459de0e7f3cff9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_2fdd8a774a3284e223459de0e7f3cff9(s, config);
}

}


