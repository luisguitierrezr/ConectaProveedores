using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoicesReport48_5FilesRecord
public class JSONRC_b73f0c67ffc0008d77cac753ae1f90dc : AbstractRESTStructure<RC_b73f0c67ffc0008d77cac753ae1f90dc> {
[JsonProperty("InvoicesReport48_5Files")]
[JsonPropertyName("InvoicesReport48_5Files")]
public ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure AttrInvoicesReport48_5Files;

public JSONRC_b73f0c67ffc0008d77cac753ae1f90dc() { }

public JSONRC_b73f0c67ffc0008d77cac753ae1f90dc (RC_b73f0c67ffc0008d77cac753ae1f90dc s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoicesReport48_5Files = ConvertToRestWithoutDefaults(s.ssSTInvoicesReport48_5Files, new ST_67affae36317a1bf9109868208ade0a8Structure(), ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure.FromStructure, config);
  } else {
AttrInvoicesReport48_5Files = ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure.FromStructure(s.ssSTInvoicesReport48_5Files, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_b73f0c67ffc0008d77cac753ae1f90dc, RC_b73f0c67ffc0008d77cac753ae1f90dc> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_b73f0c67ffc0008d77cac753ae1f90dc s) => ToStructure(s, config);
}
public static RC_b73f0c67ffc0008d77cac753ae1f90dc ToStructure(ssConectaProveedores.RestRecords.JSONRC_b73f0c67ffc0008d77cac753ae1f90dc obj, IBehaviorsConfiguration config) { 
  RC_b73f0c67ffc0008d77cac753ae1f90dc s = new RC_b73f0c67ffc0008d77cac753ae1f90dc();
  if(obj != null) {
  s.ssSTInvoicesReport48_5Files = ssConectaProveedores.RestRecords.JSONST_67affae36317a1bf9109868208ade0a8Structure.ToStructure(obj.AttrInvoicesReport48_5Files, config);
  }
  return s;
}

public static Func<RC_b73f0c67ffc0008d77cac753ae1f90dc, ssConectaProveedores.RestRecords.JSONRC_b73f0c67ffc0008d77cac753ae1f90dc> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b73f0c67ffc0008d77cac753ae1f90dc s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_b73f0c67ffc0008d77cac753ae1f90dc FromStructure(RC_b73f0c67ffc0008d77cac753ae1f90dc s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_b73f0c67ffc0008d77cac753ae1f90dc(s, config);
}

}


