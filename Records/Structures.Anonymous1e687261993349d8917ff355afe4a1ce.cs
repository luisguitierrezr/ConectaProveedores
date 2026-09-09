namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (YXJoHjOZ2EmRf_NVr+Shzg)
///  <code>RC_0468f02f35e6ccd6a092f321c5d8a88e</code> that represents <code>CurrencyRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CurrencyRecord
public partial struct RC_0468f02f35e6ccd6a092f321c5d8a88e : ITypedRecord<RC_0468f02f35e6ccd6a092f321c5d8a88e> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;


public static implicit operator EN_327b52812b8badb247bde4975c10d441EntityRecord( RC_0468f02f35e6ccd6a092f321c5d8a88e r) {
return r.ssENCurrency;
}

public static implicit operator RC_0468f02f35e6ccd6a092f321c5d8a88e (EN_327b52812b8badb247bde4975c10d441EntityRecord r) {
RC_0468f02f35e6ccd6a092f321c5d8a88e res = new RC_0468f02f35e6ccd6a092f321c5d8a88e ();
res.ssENCurrency = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCurrency.ChangedAttributes = value;
}
get {
    return ssENCurrency.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0468f02f35e6ccd6a092f321c5d8a88e() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCurrency.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
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
public void ReadIM(RC_0468f02f35e6ccd6a092f321c5d8a88e r) {
this = r;
}


public static bool operator == (RC_0468f02f35e6ccd6a092f321c5d8a88e a, RC_0468f02f35e6ccd6a092f321c5d8a88e b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
return true;
}

public static bool operator != (RC_0468f02f35e6ccd6a092f321c5d8a88e a, RC_0468f02f35e6ccd6a092f321c5d8a88e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0468f02f35e6ccd6a092f321c5d8a88e)) return false;
return (this == (RC_0468f02f35e6ccd6a092f321c5d8a88e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
}


public RC_0468f02f35e6ccd6a092f321c5d8a88e Duplicate() {
RC_0468f02f35e6ccd6a092f321c5d8a88e t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCurrency.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCurrency.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCurrency) {
return ssENCurrency;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
}
} // RC_0468f02f35e6ccd6a092f321c5d8a88e
/// <summary>
/// RecordList type <code>CurrencyRecordList</code> that represents a record list of
///  <code>Currency</code>
/// </summary>
public partial class RL_1353a59e0688582d82bbddc41b47193e : GenericRecordList<RC_0468f02f35e6ccd6a092f321c5d8a88e>, IEnumerable, IEnumerator {

protected override RC_0468f02f35e6ccd6a092f321c5d8a88e GetElementDefaultValue() {
return new RC_0468f02f35e6ccd6a092f321c5d8a88e();
}

public T[] ToArray<T>(Func<RC_0468f02f35e6ccd6a092f321c5d8a88e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1353a59e0688582d82bbddc41b47193e recordList, Func<RC_0468f02f35e6ccd6a092f321c5d8a88e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1353a59e0688582d82bbddc41b47193e(RC_0468f02f35e6ccd6a092f321c5d8a88e[] array) {
  RL_1353a59e0688582d82bbddc41b47193e result = new RL_1353a59e0688582d82bbddc41b47193e();
result.InnerFromArray(array);
    return result;
}

public static RL_1353a59e0688582d82bbddc41b47193e ToList<T>(T[] array, Func <T, RC_0468f02f35e6ccd6a092f321c5d8a88e> converter) {
  RL_1353a59e0688582d82bbddc41b47193e result = new RL_1353a59e0688582d82bbddc41b47193e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1353a59e0688582d82bbddc41b47193e FromRestList<T>(RestList<T> restList, Func <T, RC_0468f02f35e6ccd6a092f321c5d8a88e> converter) {
  RL_1353a59e0688582d82bbddc41b47193e result = new RL_1353a59e0688582d82bbddc41b47193e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1353a59e0688582d82bbddc41b47193e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0468f02f35e6ccd6a092f321c5d8a88e> NewList() {
return new RL_1353a59e0688582d82bbddc41b47193e();
}


} // RL_1353a59e0688582d82bbddc41b47193e
}

