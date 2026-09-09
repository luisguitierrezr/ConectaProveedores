namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (bb0gx3_210qg+J_UQ0b1iA)
///  <code>RC_5f047dfa5f07a0c48614f5e378a26f43</code> that represents <code>IntegerRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: IntegerRecord
public partial struct RC_5f047dfa5f07a0c48614f5e378a26f43 : ITypedRecord<RC_5f047dfa5f07a0c48614f5e378a26f43> {
internal static readonly GlobalObjectKey IdInteger = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+n0EXwdfxKCGFPXjeKJvQw");

public ST_e4103a4d41689de0feae1065888fc2e0Structure ssSTInteger;


public static implicit operator ST_e4103a4d41689de0feae1065888fc2e0Structure( RC_5f047dfa5f07a0c48614f5e378a26f43 r) {
return r.ssSTInteger;
}

public static implicit operator RC_5f047dfa5f07a0c48614f5e378a26f43 (ST_e4103a4d41689de0feae1065888fc2e0Structure r) {
RC_5f047dfa5f07a0c48614f5e378a26f43 res = new RC_5f047dfa5f07a0c48614f5e378a26f43 ();
res.ssSTInteger = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_5f047dfa5f07a0c48614f5e378a26f43() {
OptimizedAttributes = null;
ssSTInteger = new ST_e4103a4d41689de0feae1065888fc2e0Structure();
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
    ssSTInteger.OptimizedAttributes = value[0];
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
ssSTInteger.Read( r, ref index);
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
public void ReadIM(RC_5f047dfa5f07a0c48614f5e378a26f43 r) {
this = r;
}


public static bool operator == (RC_5f047dfa5f07a0c48614f5e378a26f43 a, RC_5f047dfa5f07a0c48614f5e378a26f43 b) {
if (a.ssSTInteger != b.ssSTInteger) return false;
return true;
}

public static bool operator != (RC_5f047dfa5f07a0c48614f5e378a26f43 a, RC_5f047dfa5f07a0c48614f5e378a26f43 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5f047dfa5f07a0c48614f5e378a26f43)) return false;
return (this == (RC_5f047dfa5f07a0c48614f5e378a26f43)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInteger.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInteger.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInteger.InternalRecursiveSave();
}


public RC_5f047dfa5f07a0c48614f5e378a26f43 Duplicate() {
RC_5f047dfa5f07a0c48614f5e378a26f43 t;
t.ssSTInteger = (ST_e4103a4d41689de0feae1065888fc2e0Structure)this.ssSTInteger.Duplicate();
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
if (head == "integer") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Integer")) variable.Value = ssSTInteger; else variable.Optimized = true;
variable.SetFieldName("integer");
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
if (key == IdInteger) {
return ssSTInteger;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInteger.Key.AsGuid) {
return ssSTInteger;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInteger.FillFromOther((IRecord) other.AttributeGet(IdInteger));
}
} // RC_5f047dfa5f07a0c48614f5e378a26f43
/// <summary>
/// RecordList type <code>IntegerRecordList</code> that represents a record list of
///  <code>Integer</code>
/// </summary>
public partial class RL_eb723ca0f1d2182a5703efa79cc03660 : GenericRecordList<RC_5f047dfa5f07a0c48614f5e378a26f43>, IEnumerable, IEnumerator {

protected override RC_5f047dfa5f07a0c48614f5e378a26f43 GetElementDefaultValue() {
return new RC_5f047dfa5f07a0c48614f5e378a26f43();
}

public T[] ToArray<T>(Func<RC_5f047dfa5f07a0c48614f5e378a26f43, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_eb723ca0f1d2182a5703efa79cc03660 recordList, Func<RC_5f047dfa5f07a0c48614f5e378a26f43, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_eb723ca0f1d2182a5703efa79cc03660(RC_5f047dfa5f07a0c48614f5e378a26f43[] array) {
  RL_eb723ca0f1d2182a5703efa79cc03660 result = new RL_eb723ca0f1d2182a5703efa79cc03660();
result.InnerFromArray(array);
    return result;
}

public static RL_eb723ca0f1d2182a5703efa79cc03660 ToList<T>(T[] array, Func <T, RC_5f047dfa5f07a0c48614f5e378a26f43> converter) {
  RL_eb723ca0f1d2182a5703efa79cc03660 result = new RL_eb723ca0f1d2182a5703efa79cc03660();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_eb723ca0f1d2182a5703efa79cc03660 FromRestList<T>(RestList<T> restList, Func <T, RC_5f047dfa5f07a0c48614f5e378a26f43> converter) {
  RL_eb723ca0f1d2182a5703efa79cc03660 result = new RL_eb723ca0f1d2182a5703efa79cc03660();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_eb723ca0f1d2182a5703efa79cc03660() : base() {
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
protected override OSList<RC_5f047dfa5f07a0c48614f5e378a26f43> NewList() {
return new RL_eb723ca0f1d2182a5703efa79cc03660();
}


} // RL_eb723ca0f1d2182a5703efa79cc03660
}

