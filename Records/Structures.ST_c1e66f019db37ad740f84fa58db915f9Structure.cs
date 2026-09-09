namespace ssConectaProveedores {
/// <summary>
/// [Structure] DocumentExtrationSupplier (zbPGhU5NYEqPI6L_QxMkVQ)
///  <code>ST_c1e66f019db37ad740f84fa58db915f9Structure</code> that represent
/// s <code>DocumentExtrationSupplier</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationSupplier
public partial struct ST_c1e66f019db37ad740f84fa58db915f9Structure : ITypedRecord<ST_c1e66f019db37ad740f84fa58db915f9Structure> {
internal static readonly GlobalObjectKey IdNumerodeProveedor = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*UWKBLI5glUy_r3nMixlZ2Q");
internal static readonly GlobalObjectKey IdNombreoRazonSocial = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8QPd_KsKxEejkx3e4BPOwQ");
internal static readonly GlobalObjectKey IdDesde = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*KN3XSSO7IU6V2g2_SSbgoA");
internal static readonly GlobalObjectKey IdHasta = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*zlDNBIHEWEKvXD1KDERkHA");
internal static readonly GlobalObjectKey IdSpace = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*hEsazVdMH0m2B2XqHo5vSA");
internal static readonly GlobalObjectKey IdNumerodeProveedor2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*2YEauNf_k0KH5TOLsh8o0A");
internal static readonly GlobalObjectKey IdNombreoRazonSocial2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NY_UVE6aRE+CIqy0jDmp6g");
internal static readonly GlobalObjectKey IdDesde2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*3sHEnoTSL0CeCfCWU0Gqqg");
internal static readonly GlobalObjectKey IdHasta2 = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QN43ULZwLUq88SuNzQim+A");

public string ssNumerodeProveedor;

public string ssNombreoRazonSocial;

public string ssDesde;

public string ssHasta;

public string ssSpace;

public string ssNumerodeProveedor2;

public string ssNombreoRazonSocial2;

public string ssDesde2;

public string ssHasta2;


public BitArray OptimizedAttributes;

public ST_c1e66f019db37ad740f84fa58db915f9Structure() {
OptimizedAttributes = null;
ssNumerodeProveedor = "";
ssNombreoRazonSocial = "";
ssDesde = "";
ssHasta = "";
ssSpace = "";
ssNumerodeProveedor2 = "";
ssNombreoRazonSocial2 = "";
ssDesde2 = "";
ssHasta2 = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssNumerodeProveedor = r.ReadText(index++, "DocumentExtrationSupplier.NumerodeProveedor", "");
ssNombreoRazonSocial = r.ReadText(index++, "DocumentExtrationSupplier.NombreoRazonSocial", "");
ssDesde = r.ReadText(index++, "DocumentExtrationSupplier.Desde", "");
ssHasta = r.ReadText(index++, "DocumentExtrationSupplier.Hasta", "");
ssSpace = r.ReadText(index++, "DocumentExtrationSupplier.Space", "");
ssNumerodeProveedor2 = r.ReadText(index++, "DocumentExtrationSupplier.NumerodeProveedor2", "");
ssNombreoRazonSocial2 = r.ReadText(index++, "DocumentExtrationSupplier.NombreoRazonSocial2", "");
ssDesde2 = r.ReadText(index++, "DocumentExtrationSupplier.Desde2", "");
ssHasta2 = r.ReadText(index++, "DocumentExtrationSupplier.Hasta2", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_c1e66f019db37ad740f84fa58db915f9Structure r) {
this = r;
}


public static bool operator == (ST_c1e66f019db37ad740f84fa58db915f9Structure a, ST_c1e66f019db37ad740f84fa58db915f9Structure b) {
if (a.ssNumerodeProveedor != b.ssNumerodeProveedor) return false;
if (a.ssNombreoRazonSocial != b.ssNombreoRazonSocial) return false;
if (a.ssDesde != b.ssDesde) return false;
if (a.ssHasta != b.ssHasta) return false;
if (a.ssSpace != b.ssSpace) return false;
if (a.ssNumerodeProveedor2 != b.ssNumerodeProveedor2) return false;
if (a.ssNombreoRazonSocial2 != b.ssNombreoRazonSocial2) return false;
if (a.ssDesde2 != b.ssDesde2) return false;
if (a.ssHasta2 != b.ssHasta2) return false;
return true;
}

public static bool operator != (ST_c1e66f019db37ad740f84fa58db915f9Structure a, ST_c1e66f019db37ad740f84fa58db915f9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_c1e66f019db37ad740f84fa58db915f9Structure)) return false;
return (this == (ST_c1e66f019db37ad740f84fa58db915f9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssNumerodeProveedor.GetHashCode()
 ^ ssNombreoRazonSocial.GetHashCode()
 ^ ssDesde.GetHashCode()
 ^ ssHasta.GetHashCode()
 ^ ssSpace.GetHashCode()
 ^ ssNumerodeProveedor2.GetHashCode()
 ^ ssNombreoRazonSocial2.GetHashCode()
 ^ ssDesde2.GetHashCode()
 ^ ssHasta2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_c1e66f019db37ad740f84fa58db915f9Structure Duplicate() {
ST_c1e66f019db37ad740f84fa58db915f9Structure t;
t.ssNumerodeProveedor = this.ssNumerodeProveedor;
t.ssNombreoRazonSocial = this.ssNombreoRazonSocial;
t.ssDesde = this.ssDesde;
t.ssHasta = this.ssHasta;
t.ssSpace = this.ssSpace;
t.ssNumerodeProveedor2 = this.ssNumerodeProveedor2;
t.ssNombreoRazonSocial2 = this.ssNombreoRazonSocial2;
t.ssDesde2 = this.ssDesde2;
t.ssHasta2 = this.ssHasta2;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "numerodeproveedor") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumerodeProveedor")) variable.Value = ssNumerodeProveedor; else variable.Optimized = true;
} else if (head == "nombreorazonsocial") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NombreoRazonSocial")) variable.Value = ssNombreoRazonSocial; else variable.Optimized = true;
} else if (head == "desde") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde")) variable.Value = ssDesde; else variable.Optimized = true;
} else if (head == "hasta") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta")) variable.Value = ssHasta; else variable.Optimized = true;
} else if (head == "space") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Space")) variable.Value = ssSpace; else variable.Optimized = true;
} else if (head == "numerodeproveedor2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NumerodeProveedor2")) variable.Value = ssNumerodeProveedor2; else variable.Optimized = true;
} else if (head == "nombreorazonsocial2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NombreoRazonSocial2")) variable.Value = ssNombreoRazonSocial2; else variable.Optimized = true;
} else if (head == "desde2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Desde2")) variable.Value = ssDesde2; else variable.Optimized = true;
} else if (head == "hasta2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Hasta2")) variable.Value = ssHasta2; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdNumerodeProveedor) {
return ssNumerodeProveedor;
}
if (key == IdNombreoRazonSocial) {
return ssNombreoRazonSocial;
}
if (key == IdDesde) {
return ssDesde;
}
if (key == IdHasta) {
return ssHasta;
}
if (key == IdSpace) {
return ssSpace;
}
if (key == IdNumerodeProveedor2) {
return ssNumerodeProveedor2;
}
if (key == IdNombreoRazonSocial2) {
return ssNombreoRazonSocial2;
}
if (key == IdDesde2) {
return ssDesde2;
}
if (key == IdHasta2) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdNumerodeProveedor.Key.AsGuid) {
return ssNumerodeProveedor;
}
if (attributeKey == IdNombreoRazonSocial.Key.AsGuid) {
return ssNombreoRazonSocial;
}
if (attributeKey == IdDesde.Key.AsGuid) {
return ssDesde;
}
if (attributeKey == IdHasta.Key.AsGuid) {
return ssHasta;
}
if (attributeKey == IdSpace.Key.AsGuid) {
return ssSpace;
}
if (attributeKey == IdNumerodeProveedor2.Key.AsGuid) {
return ssNumerodeProveedor2;
}
if (attributeKey == IdNombreoRazonSocial2.Key.AsGuid) {
return ssNombreoRazonSocial2;
}
if (attributeKey == IdDesde2.Key.AsGuid) {
return ssDesde2;
}
if (attributeKey == IdHasta2.Key.AsGuid) {
return ssHasta2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssNumerodeProveedor = (string) other.AttributeGet(IdNumerodeProveedor);
ssNombreoRazonSocial = (string) other.AttributeGet(IdNombreoRazonSocial);
ssDesde = (string) other.AttributeGet(IdDesde);
ssHasta = (string) other.AttributeGet(IdHasta);
ssSpace = (string) other.AttributeGet(IdSpace);
ssNumerodeProveedor2 = (string) other.AttributeGet(IdNumerodeProveedor2);
ssNombreoRazonSocial2 = (string) other.AttributeGet(IdNombreoRazonSocial2);
ssDesde2 = (string) other.AttributeGet(IdDesde2);
ssHasta2 = (string) other.AttributeGet(IdHasta2);
}
} // ST_c1e66f019db37ad740f84fa58db915f9Structure
/// <summary>
/// RecordList type <code>DocumentExtrationSupplierList</code> that represents a record list of
///  <code>DocumentExtrationSupplier</code>
/// </summary>
public partial class RL_2d965934f404b86cc8660f63cbfac58f : GenericRecordList<ST_c1e66f019db37ad740f84fa58db915f9Structure>, IEnumerable, IEnumerator {

protected override ST_c1e66f019db37ad740f84fa58db915f9Structure GetElementDefaultValue() {
return new ST_c1e66f019db37ad740f84fa58db915f9Structure();
}

public T[] ToArray<T>(Func<ST_c1e66f019db37ad740f84fa58db915f9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2d965934f404b86cc8660f63cbfac58f recordList, Func<ST_c1e66f019db37ad740f84fa58db915f9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2d965934f404b86cc8660f63cbfac58f(ST_c1e66f019db37ad740f84fa58db915f9Structure[] array) {
  RL_2d965934f404b86cc8660f63cbfac58f result = new RL_2d965934f404b86cc8660f63cbfac58f();
result.InnerFromArray(array);
    return result;
}

public static RL_2d965934f404b86cc8660f63cbfac58f ToList<T>(T[] array, Func <T, ST_c1e66f019db37ad740f84fa58db915f9Structure> converter) {
  RL_2d965934f404b86cc8660f63cbfac58f result = new RL_2d965934f404b86cc8660f63cbfac58f();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2d965934f404b86cc8660f63cbfac58f FromRestList<T>(RestList<T> restList, Func <T, ST_c1e66f019db37ad740f84fa58db915f9Structure> converter) {
  RL_2d965934f404b86cc8660f63cbfac58f result = new RL_2d965934f404b86cc8660f63cbfac58f();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2d965934f404b86cc8660f63cbfac58f() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_c1e66f019db37ad740f84fa58db915f9Structure> NewList() {
return new RL_2d965934f404b86cc8660f63cbfac58f();
}


} // RL_2d965934f404b86cc8660f63cbfac58f
}

