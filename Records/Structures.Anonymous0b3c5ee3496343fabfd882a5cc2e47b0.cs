namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4148C2NJ+kO_2IKlzC5HsA)
///  <code>RC_5460c4bf9b3f96576a08e29ae969cbe7</code> that represents <code>OrderCostCenterRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrderCostCenterRecord
public partial struct RC_5460c4bf9b3f96576a08e29ae969cbe7 : ITypedRecord<RC_5460c4bf9b3f96576a08e29ae969cbe7> {
internal static readonly GlobalObjectKey IdOrderCostCenter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*v8RgVD+bV5ZqCOKa6WnL5w");

public EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord ssENOrderCostCenter;


public static implicit operator EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord( RC_5460c4bf9b3f96576a08e29ae969cbe7 r) {
return r.ssENOrderCostCenter;
}

public static implicit operator RC_5460c4bf9b3f96576a08e29ae969cbe7 (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord r) {
RC_5460c4bf9b3f96576a08e29ae969cbe7 res = new RC_5460c4bf9b3f96576a08e29ae969cbe7 ();
res.ssENOrderCostCenter = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderCostCenter.ChangedAttributes = value;
}
get {
    return ssENOrderCostCenter.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5460c4bf9b3f96576a08e29ae969cbe7() {
OptimizedAttributes = null;
ssENOrderCostCenter = new EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(3,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderCostCenter.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderCostCenter.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderCostCenter.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderCostCenter.Read( r, ref index);
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
public void ReadIM(RC_5460c4bf9b3f96576a08e29ae969cbe7 r) {
this = r;
}


public static bool operator == (RC_5460c4bf9b3f96576a08e29ae969cbe7 a, RC_5460c4bf9b3f96576a08e29ae969cbe7 b) {
if (a.ssENOrderCostCenter != b.ssENOrderCostCenter) return false;
return true;
}

public static bool operator != (RC_5460c4bf9b3f96576a08e29ae969cbe7 a, RC_5460c4bf9b3f96576a08e29ae969cbe7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5460c4bf9b3f96576a08e29ae969cbe7)) return false;
return (this == (RC_5460c4bf9b3f96576a08e29ae969cbe7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderCostCenter.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderCostCenter.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderCostCenter.InternalRecursiveSave();
}


public RC_5460c4bf9b3f96576a08e29ae969cbe7 Duplicate() {
RC_5460c4bf9b3f96576a08e29ae969cbe7 t;
t.ssENOrderCostCenter = (EN_07f20b06e382f3bc3dadd44791946f9dEntityRecord)this.ssENOrderCostCenter.Duplicate();
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
if (head == "ordercostcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderCostCenter")) variable.Value = ssENOrderCostCenter; else variable.Optimized = true;
variable.SetFieldName("ordercostcenter");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderCostCenter.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderCostCenter.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderCostCenter) {
return ssENOrderCostCenter;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderCostCenter.Key.AsGuid) {
return ssENOrderCostCenter;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderCostCenter.FillFromOther((IRecord) other.AttributeGet(IdOrderCostCenter));
}
} // RC_5460c4bf9b3f96576a08e29ae969cbe7
/// <summary>
/// RecordList type <code>OrderCostCenterRecordList</code> that represents a record list of
///  <code>OrderCostCenter</code>
/// </summary>
public partial class RL_43938fed4828c141405588b16ed6882e : GenericRecordList<RC_5460c4bf9b3f96576a08e29ae969cbe7>, IEnumerable, IEnumerator {

protected override RC_5460c4bf9b3f96576a08e29ae969cbe7 GetElementDefaultValue() {
return new RC_5460c4bf9b3f96576a08e29ae969cbe7();
}

public T[] ToArray<T>(Func<RC_5460c4bf9b3f96576a08e29ae969cbe7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_43938fed4828c141405588b16ed6882e recordList, Func<RC_5460c4bf9b3f96576a08e29ae969cbe7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_43938fed4828c141405588b16ed6882e(RC_5460c4bf9b3f96576a08e29ae969cbe7[] array) {
  RL_43938fed4828c141405588b16ed6882e result = new RL_43938fed4828c141405588b16ed6882e();
result.InnerFromArray(array);
    return result;
}

public static RL_43938fed4828c141405588b16ed6882e ToList<T>(T[] array, Func <T, RC_5460c4bf9b3f96576a08e29ae969cbe7> converter) {
  RL_43938fed4828c141405588b16ed6882e result = new RL_43938fed4828c141405588b16ed6882e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_43938fed4828c141405588b16ed6882e FromRestList<T>(RestList<T> restList, Func <T, RC_5460c4bf9b3f96576a08e29ae969cbe7> converter) {
  RL_43938fed4828c141405588b16ed6882e result = new RL_43938fed4828c141405588b16ed6882e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_43938fed4828c141405588b16ed6882e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(3,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5460c4bf9b3f96576a08e29ae969cbe7> NewList() {
return new RL_43938fed4828c141405588b16ed6882e();
}


} // RL_43938fed4828c141405588b16ed6882e
}

