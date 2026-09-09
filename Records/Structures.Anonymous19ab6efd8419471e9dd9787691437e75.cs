namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_W6rGRmEHked2Xh2kUN+dQ)
///  <code>RC_49a19a6c249aebfaa8459808b60b7646</code> that represents <code>TI_ITEM_InRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_ITEM_InRecord
public partial struct RC_49a19a6c249aebfaa8459808b60b7646 : ITypedRecord<RC_49a19a6c249aebfaa8459808b60b7646> {
internal static readonly GlobalObjectKey IdTI_ITEM_In = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bJqhSZok+uuoRZgItgt2Rg");

public ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure ssSTTI_ITEM_In;


public static implicit operator ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure( RC_49a19a6c249aebfaa8459808b60b7646 r) {
return r.ssSTTI_ITEM_In;
}

public static implicit operator RC_49a19a6c249aebfaa8459808b60b7646 (ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure r) {
RC_49a19a6c249aebfaa8459808b60b7646 res = new RC_49a19a6c249aebfaa8459808b60b7646 ();
res.ssSTTI_ITEM_In = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_49a19a6c249aebfaa8459808b60b7646() {
OptimizedAttributes = null;
ssSTTI_ITEM_In = new ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure();
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
    ssSTTI_ITEM_In.OptimizedAttributes = value[0];
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
ssSTTI_ITEM_In.Read( r, ref index);
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
public void ReadIM(RC_49a19a6c249aebfaa8459808b60b7646 r) {
this = r;
}


public static bool operator == (RC_49a19a6c249aebfaa8459808b60b7646 a, RC_49a19a6c249aebfaa8459808b60b7646 b) {
if (a.ssSTTI_ITEM_In != b.ssSTTI_ITEM_In) return false;
return true;
}

public static bool operator != (RC_49a19a6c249aebfaa8459808b60b7646 a, RC_49a19a6c249aebfaa8459808b60b7646 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_49a19a6c249aebfaa8459808b60b7646)) return false;
return (this == (RC_49a19a6c249aebfaa8459808b60b7646)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTTI_ITEM_In.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTTI_ITEM_In.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTTI_ITEM_In.InternalRecursiveSave();
}


public RC_49a19a6c249aebfaa8459808b60b7646 Duplicate() {
RC_49a19a6c249aebfaa8459808b60b7646 t;
t.ssSTTI_ITEM_In = (ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure)this.ssSTTI_ITEM_In.Duplicate();
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
if (head == "ti_item_in") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TI_ITEM_In")) variable.Value = ssSTTI_ITEM_In; else variable.Optimized = true;
variable.SetFieldName("ti_item_in");
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
if (key == IdTI_ITEM_In) {
return ssSTTI_ITEM_In;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTI_ITEM_In.Key.AsGuid) {
return ssSTTI_ITEM_In;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTTI_ITEM_In.FillFromOther((IRecord) other.AttributeGet(IdTI_ITEM_In));
}
} // RC_49a19a6c249aebfaa8459808b60b7646
/// <summary>
/// RecordList type <code>TI_ITEM_InRecordList</code> that represents a record list of
///  <code>TI_ITEM_In</code>
/// </summary>
public partial class RL_c9eeb9dbdb1986f0b27d50e16e46db07 : GenericRecordList<RC_49a19a6c249aebfaa8459808b60b7646>, IEnumerable, IEnumerator {

protected override RC_49a19a6c249aebfaa8459808b60b7646 GetElementDefaultValue() {
return new RC_49a19a6c249aebfaa8459808b60b7646();
}

public T[] ToArray<T>(Func<RC_49a19a6c249aebfaa8459808b60b7646, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c9eeb9dbdb1986f0b27d50e16e46db07 recordList, Func<RC_49a19a6c249aebfaa8459808b60b7646, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c9eeb9dbdb1986f0b27d50e16e46db07(RC_49a19a6c249aebfaa8459808b60b7646[] array) {
  RL_c9eeb9dbdb1986f0b27d50e16e46db07 result = new RL_c9eeb9dbdb1986f0b27d50e16e46db07();
result.InnerFromArray(array);
    return result;
}

public static RL_c9eeb9dbdb1986f0b27d50e16e46db07 ToList<T>(T[] array, Func <T, RC_49a19a6c249aebfaa8459808b60b7646> converter) {
  RL_c9eeb9dbdb1986f0b27d50e16e46db07 result = new RL_c9eeb9dbdb1986f0b27d50e16e46db07();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c9eeb9dbdb1986f0b27d50e16e46db07 FromRestList<T>(RestList<T> restList, Func <T, RC_49a19a6c249aebfaa8459808b60b7646> converter) {
  RL_c9eeb9dbdb1986f0b27d50e16e46db07 result = new RL_c9eeb9dbdb1986f0b27d50e16e46db07();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c9eeb9dbdb1986f0b27d50e16e46db07() : base() {
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
protected override OSList<RC_49a19a6c249aebfaa8459808b60b7646> NewList() {
return new RL_c9eeb9dbdb1986f0b27d50e16e46db07();
}


} // RL_c9eeb9dbdb1986f0b27d50e16e46db07
}

