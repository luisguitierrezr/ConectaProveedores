namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (zSljLHdYiE6pfdTPPSi1tQ)
///  <code>RC_7d4bec7bab5f921632c0f5cba3ea0ec2</code> that represent
/// s <code>EM_COSMOZ_RequestRecord</code> <p>Description: </p>
/// </summary>
// Name: EM_COSMOZ_RequestRecord
public partial struct RC_7d4bec7bab5f921632c0f5cba3ea0ec2 : ITypedRecord<RC_7d4bec7bab5f921632c0f5cba3ea0ec2> {
internal static readonly GlobalObjectKey IdEM_COSMOZ_Request = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e+xLfV+rFpIywPXLo+oOwg");

public ST_471afc38d91cd307b39846c7ca5ddb86Structure ssSTEM_COSMOZ_Request;


public static implicit operator ST_471afc38d91cd307b39846c7ca5ddb86Structure( RC_7d4bec7bab5f921632c0f5cba3ea0ec2 r) {
return r.ssSTEM_COSMOZ_Request;
}

public static implicit operator RC_7d4bec7bab5f921632c0f5cba3ea0ec2 (ST_471afc38d91cd307b39846c7ca5ddb86Structure r) {
RC_7d4bec7bab5f921632c0f5cba3ea0ec2 res = new RC_7d4bec7bab5f921632c0f5cba3ea0ec2 ();
res.ssSTEM_COSMOZ_Request = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_7d4bec7bab5f921632c0f5cba3ea0ec2() {
OptimizedAttributes = null;
ssSTEM_COSMOZ_Request = new ST_471afc38d91cd307b39846c7ca5ddb86Structure();
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
    ssSTEM_COSMOZ_Request.OptimizedAttributes = value[0];
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
ssSTEM_COSMOZ_Request.Read( r, ref index);
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
public void ReadIM(RC_7d4bec7bab5f921632c0f5cba3ea0ec2 r) {
this = r;
}


public static bool operator == (RC_7d4bec7bab5f921632c0f5cba3ea0ec2 a, RC_7d4bec7bab5f921632c0f5cba3ea0ec2 b) {
if (a.ssSTEM_COSMOZ_Request != b.ssSTEM_COSMOZ_Request) return false;
return true;
}

public static bool operator != (RC_7d4bec7bab5f921632c0f5cba3ea0ec2 a, RC_7d4bec7bab5f921632c0f5cba3ea0ec2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7d4bec7bab5f921632c0f5cba3ea0ec2)) return false;
return (this == (RC_7d4bec7bab5f921632c0f5cba3ea0ec2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTEM_COSMOZ_Request.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTEM_COSMOZ_Request.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTEM_COSMOZ_Request.InternalRecursiveSave();
}


public RC_7d4bec7bab5f921632c0f5cba3ea0ec2 Duplicate() {
RC_7d4bec7bab5f921632c0f5cba3ea0ec2 t;
t.ssSTEM_COSMOZ_Request = (ST_471afc38d91cd307b39846c7ca5ddb86Structure)this.ssSTEM_COSMOZ_Request.Duplicate();
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
if (head == "em_cosmoz_request") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".EM_COSMOZ_Request")) variable.Value = ssSTEM_COSMOZ_Request; else variable.Optimized = true;
variable.SetFieldName("em_cosmoz_request");
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
if (key == IdEM_COSMOZ_Request) {
return ssSTEM_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdEM_COSMOZ_Request.Key.AsGuid) {
return ssSTEM_COSMOZ_Request;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTEM_COSMOZ_Request.FillFromOther((IRecord) other.AttributeGet(IdEM_COSMOZ_Request));
}
} // RC_7d4bec7bab5f921632c0f5cba3ea0ec2
/// <summary>
/// RecordList type <code>EM_COSMOZ_RequestRecordList</code> that represents a record list of
///  <code>EM_COSMOZ_Request</code>
/// </summary>
public partial class RL_714b0b165db66678d8a42ec91cdddc80 : GenericRecordList<RC_7d4bec7bab5f921632c0f5cba3ea0ec2>, IEnumerable, IEnumerator {

protected override RC_7d4bec7bab5f921632c0f5cba3ea0ec2 GetElementDefaultValue() {
return new RC_7d4bec7bab5f921632c0f5cba3ea0ec2();
}

public T[] ToArray<T>(Func<RC_7d4bec7bab5f921632c0f5cba3ea0ec2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_714b0b165db66678d8a42ec91cdddc80 recordList, Func<RC_7d4bec7bab5f921632c0f5cba3ea0ec2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_714b0b165db66678d8a42ec91cdddc80(RC_7d4bec7bab5f921632c0f5cba3ea0ec2[] array) {
  RL_714b0b165db66678d8a42ec91cdddc80 result = new RL_714b0b165db66678d8a42ec91cdddc80();
result.InnerFromArray(array);
    return result;
}

public static RL_714b0b165db66678d8a42ec91cdddc80 ToList<T>(T[] array, Func <T, RC_7d4bec7bab5f921632c0f5cba3ea0ec2> converter) {
  RL_714b0b165db66678d8a42ec91cdddc80 result = new RL_714b0b165db66678d8a42ec91cdddc80();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_714b0b165db66678d8a42ec91cdddc80 FromRestList<T>(RestList<T> restList, Func <T, RC_7d4bec7bab5f921632c0f5cba3ea0ec2> converter) {
  RL_714b0b165db66678d8a42ec91cdddc80 result = new RL_714b0b165db66678d8a42ec91cdddc80();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_714b0b165db66678d8a42ec91cdddc80() : base() {
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
protected override OSList<RC_7d4bec7bab5f921632c0f5cba3ea0ec2> NewList() {
return new RL_714b0b165db66678d8a42ec91cdddc80();
}


} // RL_714b0b165db66678d8a42ec91cdddc80
}

