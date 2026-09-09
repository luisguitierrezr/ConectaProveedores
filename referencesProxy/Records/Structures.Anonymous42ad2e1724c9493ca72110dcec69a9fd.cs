namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (Fy6tQskkPEmnIRDc7Gmp_Q)
///  <code>RC_ad606c6dbce21f6b806288bf3ea0b634</code> that represents <code>T_DAT_PROV_InRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: T_DAT_PROV_InRecord
public partial struct RC_ad606c6dbce21f6b806288bf3ea0b634 : ITypedRecord<RC_ad606c6dbce21f6b806288bf3ea0b634> {
internal static readonly GlobalObjectKey IdT_DAT_PROV_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bWxgreK8ax+AYoi_PqC2NA");

public ST_b19d23fc0038c4f52f978d3d75427ea7Structure ssSTT_DAT_PROV_In;


public static implicit operator ST_b19d23fc0038c4f52f978d3d75427ea7Structure( RC_ad606c6dbce21f6b806288bf3ea0b634 r) {
return r.ssSTT_DAT_PROV_In;
}

public static implicit operator RC_ad606c6dbce21f6b806288bf3ea0b634 (ST_b19d23fc0038c4f52f978d3d75427ea7Structure r) {
RC_ad606c6dbce21f6b806288bf3ea0b634 res = new RC_ad606c6dbce21f6b806288bf3ea0b634 ();
res.ssSTT_DAT_PROV_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_ad606c6dbce21f6b806288bf3ea0b634() {
OptimizedAttributes = null;
ssSTT_DAT_PROV_In = new ST_b19d23fc0038c4f52f978d3d75427ea7Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTT_DAT_PROV_In.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTT_DAT_PROV_In.Read( r, ref index);
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
public void ReadIM(RC_ad606c6dbce21f6b806288bf3ea0b634 r) {
this = r;
}


public static bool operator == (RC_ad606c6dbce21f6b806288bf3ea0b634 a, RC_ad606c6dbce21f6b806288bf3ea0b634 b) {
if (a.ssSTT_DAT_PROV_In != b.ssSTT_DAT_PROV_In) return false;
return true;
}

public static bool operator != (RC_ad606c6dbce21f6b806288bf3ea0b634 a, RC_ad606c6dbce21f6b806288bf3ea0b634 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ad606c6dbce21f6b806288bf3ea0b634)) return false;
return (this == (RC_ad606c6dbce21f6b806288bf3ea0b634)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTT_DAT_PROV_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTT_DAT_PROV_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTT_DAT_PROV_In.InternalRecursiveSave();
}


public RC_ad606c6dbce21f6b806288bf3ea0b634 Duplicate() {
RC_ad606c6dbce21f6b806288bf3ea0b634 t;
t.ssSTT_DAT_PROV_In = (ST_b19d23fc0038c4f52f978d3d75427ea7Structure)this.ssSTT_DAT_PROV_In.Duplicate();
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
if (head == "t_dat_prov_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".T_DAT_PROV_In")) variable.Value = ssSTT_DAT_PROV_In; else variable.Optimized = true;
variable.SetFieldName("t_dat_prov_in");
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
if (key == IdT_DAT_PROV_In) {
return ssSTT_DAT_PROV_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdT_DAT_PROV_In.Key.AsGuid) {
return ssSTT_DAT_PROV_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTT_DAT_PROV_In.FillFromOther((IRecord) other.AttributeGet(IdT_DAT_PROV_In));
}
} // RC_ad606c6dbce21f6b806288bf3ea0b634
/// <summary>
/// RecordList type <code>T_DAT_PROV_InRecordList</code> that represents a record list of
///  <code>T_DAT_PROV_In</code>
/// </summary>
public partial class RL_8152221db907ed6995731266673e0166 : GenericRecordList<RC_ad606c6dbce21f6b806288bf3ea0b634>, IEnumerable, IEnumerator {

protected override RC_ad606c6dbce21f6b806288bf3ea0b634 GetElementDefaultValue() {
return new RC_ad606c6dbce21f6b806288bf3ea0b634();
}

public T[] ToArray<T>(Func<RC_ad606c6dbce21f6b806288bf3ea0b634, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8152221db907ed6995731266673e0166 recordList, Func<RC_ad606c6dbce21f6b806288bf3ea0b634, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8152221db907ed6995731266673e0166(RC_ad606c6dbce21f6b806288bf3ea0b634[] array) {
  RL_8152221db907ed6995731266673e0166 result = new RL_8152221db907ed6995731266673e0166();
result.InnerFromArray(array);
    return result;
}

public static RL_8152221db907ed6995731266673e0166 ToList<T>(T[] array, Func <T, RC_ad606c6dbce21f6b806288bf3ea0b634> converter) {
  RL_8152221db907ed6995731266673e0166 result = new RL_8152221db907ed6995731266673e0166();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8152221db907ed6995731266673e0166 FromRestList<T>(RestList<T> restList, Func <T, RC_ad606c6dbce21f6b806288bf3ea0b634> converter) {
  RL_8152221db907ed6995731266673e0166 result = new RL_8152221db907ed6995731266673e0166();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8152221db907ed6995731266673e0166() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ad606c6dbce21f6b806288bf3ea0b634> NewList() {
return new RL_8152221db907ed6995731266673e0166();
}


} // RL_8152221db907ed6995731266673e0166
}

