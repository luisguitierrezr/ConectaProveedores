namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] CargaCFDResultWrapper (QlbMJtVxKE6Xb3dNolpIaQ)
///  <code>ST_3feabb059aa2546826b3076d3b237751Structure</code> that represent
/// s <code>CargaCFDResultWrapper</code> <p>Description: Carga CFD Result Wrapper</p>
/// </summary>
// Name: CargaCFDResultWrapper
public partial struct ST_3feabb059aa2546826b3076d3b237751Structure : ITypedRecord<ST_3feabb059aa2546826b3076d3b237751Structure> {
internal static readonly GlobalObjectKey IdStatus = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*wluRmQHw3k2OotEbqIhtwQ");
internal static readonly GlobalObjectKey IdDescripcionStatus = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*bt6+_6i_XEaL5TDNYwrKmQ");
internal static readonly GlobalObjectKey IdCPago = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*wbYBikhOmk+Cwt0q+mYnrA");
internal static readonly GlobalObjectKey IdClaveDescripcion = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*V2g4XhnCaU+LM2J803I4Gg");

public string ssStatus;

public string ssDescripcionStatus;

public string ssCPago;

public string ssClaveDescripcion;


public BitArray OptimizedAttributes;

public ST_3feabb059aa2546826b3076d3b237751Structure() {
OptimizedAttributes = null;
ssStatus = "";
ssDescripcionStatus = "";
ssCPago = "";
ssClaveDescripcion = "";
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
ssStatus = r.ReadText(index++, "CargaCFDResultWrapper.Status", "");
ssDescripcionStatus = r.ReadText(index++, "CargaCFDResultWrapper.DescripcionStatus", "");
ssCPago = r.ReadText(index++, "CargaCFDResultWrapper.CPago", "");
ssClaveDescripcion = r.ReadText(index++, "CargaCFDResultWrapper.ClaveDescripcion", "");
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
public void ReadIM(ST_3feabb059aa2546826b3076d3b237751Structure r) {
this = r;
}


public static bool operator == (ST_3feabb059aa2546826b3076d3b237751Structure a, ST_3feabb059aa2546826b3076d3b237751Structure b) {
if (a.ssStatus != b.ssStatus) return false;
if (a.ssDescripcionStatus != b.ssDescripcionStatus) return false;
if (a.ssCPago != b.ssCPago) return false;
if (a.ssClaveDescripcion != b.ssClaveDescripcion) return false;
return true;
}

public static bool operator != (ST_3feabb059aa2546826b3076d3b237751Structure a, ST_3feabb059aa2546826b3076d3b237751Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_3feabb059aa2546826b3076d3b237751Structure)) return false;
return (this == (ST_3feabb059aa2546826b3076d3b237751Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssStatus.GetHashCode()
 ^ ssDescripcionStatus.GetHashCode()
 ^ ssCPago.GetHashCode()
 ^ ssClaveDescripcion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_3feabb059aa2546826b3076d3b237751Structure Duplicate() {
ST_3feabb059aa2546826b3076d3b237751Structure t;
t.ssStatus = this.ssStatus;
t.ssDescripcionStatus = this.ssDescripcionStatus;
t.ssCPago = this.ssCPago;
t.ssClaveDescripcion = this.ssClaveDescripcion;
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
if (head == "status") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Status")) variable.Value = ssStatus; else variable.Optimized = true;
} else if (head == "descripcionstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DescripcionStatus")) variable.Value = ssDescripcionStatus; else variable.Optimized = true;
} else if (head == "cpago") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CPago")) variable.Value = ssCPago; else variable.Optimized = true;
} else if (head == "clavedescripcion") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ClaveDescripcion")) variable.Value = ssClaveDescripcion; else variable.Optimized = true;
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
if (key == IdStatus) {
return ssStatus;
}
if (key == IdDescripcionStatus) {
return ssDescripcionStatus;
}
if (key == IdCPago) {
return ssCPago;
}
if (key == IdClaveDescripcion) {
return ssClaveDescripcion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdStatus.Key.AsGuid) {
return ssStatus;
}
if (attributeKey == IdDescripcionStatus.Key.AsGuid) {
return ssDescripcionStatus;
}
if (attributeKey == IdCPago.Key.AsGuid) {
return ssCPago;
}
if (attributeKey == IdClaveDescripcion.Key.AsGuid) {
return ssClaveDescripcion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssStatus = (string) other.AttributeGet(IdStatus);
ssDescripcionStatus = (string) other.AttributeGet(IdDescripcionStatus);
ssCPago = (string) other.AttributeGet(IdCPago);
ssClaveDescripcion = (string) other.AttributeGet(IdClaveDescripcion);
}
} // ST_3feabb059aa2546826b3076d3b237751Structure
/// <summary>
/// RecordList type <code>CargaCFDResultWrapperList</code> that represents a record list of
///  <code>CargaCFDResultWrapper</code>
/// </summary>
public partial class RL_e4c071d4cfdad0e024521a914a51b78e : GenericRecordList<ST_3feabb059aa2546826b3076d3b237751Structure>, IEnumerable, IEnumerator {

protected override ST_3feabb059aa2546826b3076d3b237751Structure GetElementDefaultValue() {
return new ST_3feabb059aa2546826b3076d3b237751Structure();
}

public T[] ToArray<T>(Func<ST_3feabb059aa2546826b3076d3b237751Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e4c071d4cfdad0e024521a914a51b78e recordList, Func<ST_3feabb059aa2546826b3076d3b237751Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e4c071d4cfdad0e024521a914a51b78e(ST_3feabb059aa2546826b3076d3b237751Structure[] array) {
  RL_e4c071d4cfdad0e024521a914a51b78e result = new RL_e4c071d4cfdad0e024521a914a51b78e();
result.InnerFromArray(array);
    return result;
}

public static RL_e4c071d4cfdad0e024521a914a51b78e ToList<T>(T[] array, Func <T, ST_3feabb059aa2546826b3076d3b237751Structure> converter) {
  RL_e4c071d4cfdad0e024521a914a51b78e result = new RL_e4c071d4cfdad0e024521a914a51b78e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e4c071d4cfdad0e024521a914a51b78e FromRestList<T>(RestList<T> restList, Func <T, ST_3feabb059aa2546826b3076d3b237751Structure> converter) {
  RL_e4c071d4cfdad0e024521a914a51b78e result = new RL_e4c071d4cfdad0e024521a914a51b78e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e4c071d4cfdad0e024521a914a51b78e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_3feabb059aa2546826b3076d3b237751Structure> NewList() {
return new RL_e4c071d4cfdad0e024521a914a51b78e();
}


} // RL_e4c071d4cfdad0e024521a914a51b78e
}

