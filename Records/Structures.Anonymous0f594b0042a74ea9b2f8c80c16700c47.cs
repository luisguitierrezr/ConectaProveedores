namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (AEtZD6dCqU6y+MgMFnAMRw)
///  <code>RC_df806ed45594b8c12dc41d845973c44a</code> that represents <code>BankRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: BankRecord
public partial struct RC_df806ed45594b8c12dc41d845973c44a : ITypedRecord<RC_df806ed45594b8c12dc41d845973c44a> {
internal static readonly GlobalObjectKey IdBank = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*1G6A35RVwbgtxB2EWXPESg");

public EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord ssENBank;


public static implicit operator EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord( RC_df806ed45594b8c12dc41d845973c44a r) {
return r.ssENBank;
}

public static implicit operator RC_df806ed45594b8c12dc41d845973c44a (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord r) {
RC_df806ed45594b8c12dc41d845973c44a res = new RC_df806ed45594b8c12dc41d845973c44a ();
res.ssENBank = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENBank.ChangedAttributes = value;
}
get {
    return ssENBank.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_df806ed45594b8c12dc41d845973c44a() {
OptimizedAttributes = null;
ssENBank = new EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENBank.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENBank.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENBank.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENBank.Read( r, ref index);
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
public void ReadIM(RC_df806ed45594b8c12dc41d845973c44a r) {
this = r;
}


public static bool operator == (RC_df806ed45594b8c12dc41d845973c44a a, RC_df806ed45594b8c12dc41d845973c44a b) {
if (a.ssENBank != b.ssENBank) return false;
return true;
}

public static bool operator != (RC_df806ed45594b8c12dc41d845973c44a a, RC_df806ed45594b8c12dc41d845973c44a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_df806ed45594b8c12dc41d845973c44a)) return false;
return (this == (RC_df806ed45594b8c12dc41d845973c44a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENBank.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENBank.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENBank.InternalRecursiveSave();
}


public RC_df806ed45594b8c12dc41d845973c44a Duplicate() {
RC_df806ed45594b8c12dc41d845973c44a t;
t.ssENBank = (EN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord)this.ssENBank.Duplicate();
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
if (head == "bank") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Bank")) variable.Value = ssENBank; else variable.Optimized = true;
variable.SetFieldName("bank");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENBank.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENBank.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBank) {
return ssENBank;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBank.Key.AsGuid) {
return ssENBank;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENBank.FillFromOther((IRecord) other.AttributeGet(IdBank));
}
} // RC_df806ed45594b8c12dc41d845973c44a
/// <summary>
/// RecordList type <code>BankRecordList</code> that represents a record list of <code>Bank</code>
/// </summary>
public partial class RL_0fc5fa92a15115f6e97a1071c9876bcd : GenericRecordList<RC_df806ed45594b8c12dc41d845973c44a>, IEnumerable, IEnumerator {

protected override RC_df806ed45594b8c12dc41d845973c44a GetElementDefaultValue() {
return new RC_df806ed45594b8c12dc41d845973c44a();
}

public T[] ToArray<T>(Func<RC_df806ed45594b8c12dc41d845973c44a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0fc5fa92a15115f6e97a1071c9876bcd recordList, Func<RC_df806ed45594b8c12dc41d845973c44a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0fc5fa92a15115f6e97a1071c9876bcd(RC_df806ed45594b8c12dc41d845973c44a[] array) {
  RL_0fc5fa92a15115f6e97a1071c9876bcd result = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
result.InnerFromArray(array);
    return result;
}

public static RL_0fc5fa92a15115f6e97a1071c9876bcd ToList<T>(T[] array, Func <T, RC_df806ed45594b8c12dc41d845973c44a> converter) {
  RL_0fc5fa92a15115f6e97a1071c9876bcd result = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0fc5fa92a15115f6e97a1071c9876bcd FromRestList<T>(RestList<T> restList, Func <T, RC_df806ed45594b8c12dc41d845973c44a> converter) {
  RL_0fc5fa92a15115f6e97a1071c9876bcd result = new RL_0fc5fa92a15115f6e97a1071c9876bcd();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0fc5fa92a15115f6e97a1071c9876bcd() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_df806ed45594b8c12dc41d845973c44a> NewList() {
return new RL_0fc5fa92a15115f6e97a1071c9876bcd();
}


} // RL_0fc5fa92a15115f6e97a1071c9876bcd
}

