namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aTU_4GcUbkOlqSoiLniFLA)
///  <code>RC_9fc59bda41db740ae87f91f135d24811</code> that represent
/// s <code>OrderDistributionConfigRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderDistributionConfigRecord
public partial struct RC_9fc59bda41db740ae87f91f135d24811 : ITypedRecord<RC_9fc59bda41db740ae87f91f135d24811> {
internal static readonly GlobalObjectKey IdOrderDistributionConfig = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2pvFn9tBCnTof5HxNdJIEQ");

public EN_4ad0cdb13562998fda111463f2af9c31EntityRecord ssENOrderDistributionConfig;


public static implicit operator EN_4ad0cdb13562998fda111463f2af9c31EntityRecord( RC_9fc59bda41db740ae87f91f135d24811 r) {
return r.ssENOrderDistributionConfig;
}

public static implicit operator RC_9fc59bda41db740ae87f91f135d24811 (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord r) {
RC_9fc59bda41db740ae87f91f135d24811 res = new RC_9fc59bda41db740ae87f91f135d24811 ();
res.ssENOrderDistributionConfig = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderDistributionConfig.ChangedAttributes = value;
}
get {
    return ssENOrderDistributionConfig.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_9fc59bda41db740ae87f91f135d24811() {
OptimizedAttributes = null;
ssENOrderDistributionConfig = new EN_4ad0cdb13562998fda111463f2af9c31EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderDistributionConfig.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderDistributionConfig.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderDistributionConfig.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderDistributionConfig.Read( r, ref index);
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
public void ReadIM(RC_9fc59bda41db740ae87f91f135d24811 r) {
this = r;
}


public static bool operator == (RC_9fc59bda41db740ae87f91f135d24811 a, RC_9fc59bda41db740ae87f91f135d24811 b) {
if (a.ssENOrderDistributionConfig != b.ssENOrderDistributionConfig) return false;
return true;
}

public static bool operator != (RC_9fc59bda41db740ae87f91f135d24811 a, RC_9fc59bda41db740ae87f91f135d24811 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9fc59bda41db740ae87f91f135d24811)) return false;
return (this == (RC_9fc59bda41db740ae87f91f135d24811)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderDistributionConfig.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderDistributionConfig.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderDistributionConfig.InternalRecursiveSave();
}


public RC_9fc59bda41db740ae87f91f135d24811 Duplicate() {
RC_9fc59bda41db740ae87f91f135d24811 t;
t.ssENOrderDistributionConfig = (EN_4ad0cdb13562998fda111463f2af9c31EntityRecord)this.ssENOrderDistributionConfig.Duplicate();
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
if (head == "orderdistributionconfig") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDistributionConfig")) variable.Value = ssENOrderDistributionConfig; else variable.Optimized = true;
variable.SetFieldName("orderdistributionconfig");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderDistributionConfig.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderDistributionConfig.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderDistributionConfig) {
return ssENOrderDistributionConfig;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderDistributionConfig.Key.AsGuid) {
return ssENOrderDistributionConfig;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderDistributionConfig.FillFromOther((IRecord) other.AttributeGet(IdOrderDistributionConfig));
}
} // RC_9fc59bda41db740ae87f91f135d24811
/// <summary>
/// RecordList type <code>OrderDistributionConfigRecordList</code> that represents a record list of
///  <code>OrderDistributionConfig</code>
/// </summary>
public partial class RL_44cb753cf22fd0b01aa78a5ab2f30079 : GenericRecordList<RC_9fc59bda41db740ae87f91f135d24811>, IEnumerable, IEnumerator {

protected override RC_9fc59bda41db740ae87f91f135d24811 GetElementDefaultValue() {
return new RC_9fc59bda41db740ae87f91f135d24811();
}

public T[] ToArray<T>(Func<RC_9fc59bda41db740ae87f91f135d24811, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_44cb753cf22fd0b01aa78a5ab2f30079 recordList, Func<RC_9fc59bda41db740ae87f91f135d24811, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_44cb753cf22fd0b01aa78a5ab2f30079(RC_9fc59bda41db740ae87f91f135d24811[] array) {
  RL_44cb753cf22fd0b01aa78a5ab2f30079 result = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
result.InnerFromArray(array);
    return result;
}

public static RL_44cb753cf22fd0b01aa78a5ab2f30079 ToList<T>(T[] array, Func <T, RC_9fc59bda41db740ae87f91f135d24811> converter) {
  RL_44cb753cf22fd0b01aa78a5ab2f30079 result = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_44cb753cf22fd0b01aa78a5ab2f30079 FromRestList<T>(RestList<T> restList, Func <T, RC_9fc59bda41db740ae87f91f135d24811> converter) {
  RL_44cb753cf22fd0b01aa78a5ab2f30079 result = new RL_44cb753cf22fd0b01aa78a5ab2f30079();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_44cb753cf22fd0b01aa78a5ab2f30079() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9fc59bda41db740ae87f91f135d24811> NewList() {
return new RL_44cb753cf22fd0b01aa78a5ab2f30079();
}


} // RL_44cb753cf22fd0b01aa78a5ab2f30079
}

