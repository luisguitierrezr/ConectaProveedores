namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (tnaP9u6DcUCFNFJrFkYYbg)
///  <code>RC_a074711a91fd2441798a860685e4898b</code> that represent
/// s <code>CurrencyOrderMainRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyOrderMainRecord
public partial struct RC_a074711a91fd2441798a860685e4898b : ITypedRecord<RC_a074711a91fd2441798a860685e4898b> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_a074711a91fd2441798a860685e4898b() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_a074711a91fd2441798a860685e4898b r) {
this = r;
}


public static bool operator == (RC_a074711a91fd2441798a860685e4898b a, RC_a074711a91fd2441798a860685e4898b b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_a074711a91fd2441798a860685e4898b a, RC_a074711a91fd2441798a860685e4898b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a074711a91fd2441798a860685e4898b)) return false;
return (this == (RC_a074711a91fd2441798a860685e4898b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_a074711a91fd2441798a860685e4898b Duplicate() {
RC_a074711a91fd2441798a860685e4898b t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_a074711a91fd2441798a860685e4898b
/// <summary>
/// RecordList type <code>CurrencyOrderMainRecordList</code> that represents a record list of
///  <code>Currency, OrderMain</code>
/// </summary>
public partial class RL_164e5439119ae8b31002cd319dbe8413 : GenericRecordList<RC_a074711a91fd2441798a860685e4898b>, IEnumerable, IEnumerator {

protected override RC_a074711a91fd2441798a860685e4898b GetElementDefaultValue() {
return new RC_a074711a91fd2441798a860685e4898b();
}

public T[] ToArray<T>(Func<RC_a074711a91fd2441798a860685e4898b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_164e5439119ae8b31002cd319dbe8413 recordList, Func<RC_a074711a91fd2441798a860685e4898b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_164e5439119ae8b31002cd319dbe8413(RC_a074711a91fd2441798a860685e4898b[] array) {
  RL_164e5439119ae8b31002cd319dbe8413 result = new RL_164e5439119ae8b31002cd319dbe8413();
result.InnerFromArray(array);
    return result;
}

public static RL_164e5439119ae8b31002cd319dbe8413 ToList<T>(T[] array, Func <T, RC_a074711a91fd2441798a860685e4898b> converter) {
  RL_164e5439119ae8b31002cd319dbe8413 result = new RL_164e5439119ae8b31002cd319dbe8413();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_164e5439119ae8b31002cd319dbe8413 FromRestList<T>(RestList<T> restList, Func <T, RC_a074711a91fd2441798a860685e4898b> converter) {
  RL_164e5439119ae8b31002cd319dbe8413 result = new RL_164e5439119ae8b31002cd319dbe8413();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_164e5439119ae8b31002cd319dbe8413() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a074711a91fd2441798a860685e4898b> NewList() {
return new RL_164e5439119ae8b31002cd319dbe8413();
}


} // RL_164e5439119ae8b31002cd319dbe8413
}

