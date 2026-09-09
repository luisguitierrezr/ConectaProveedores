namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (TkDSxLikf0eeIgdr9SC2Kg)
///  <code>RC_a222d17a2b10e551d257fa2f5892499c</code> that represent
/// s <code>AccountingDataTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: AccountingDataTypeRecord
public partial struct RC_a222d17a2b10e551d257fa2f5892499c : ITypedRecord<RC_a222d17a2b10e551d257fa2f5892499c> {
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public static implicit operator EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord( RC_a222d17a2b10e551d257fa2f5892499c r) {
return r.ssENAccountingDataType;
}

public static implicit operator RC_a222d17a2b10e551d257fa2f5892499c (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord r) {
RC_a222d17a2b10e551d257fa2f5892499c res = new RC_a222d17a2b10e551d257fa2f5892499c ();
res.ssENAccountingDataType = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENAccountingDataType.ChangedAttributes = value;
}
get {
    return ssENAccountingDataType.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a222d17a2b10e551d257fa2f5892499c() {
OptimizedAttributes = null;
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENAccountingDataType.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENAccountingDataType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENAccountingDataType.Read( r, ref index);
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
public void ReadIM(RC_a222d17a2b10e551d257fa2f5892499c r) {
this = r;
}


public static bool operator == (RC_a222d17a2b10e551d257fa2f5892499c a, RC_a222d17a2b10e551d257fa2f5892499c b) {
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_a222d17a2b10e551d257fa2f5892499c a, RC_a222d17a2b10e551d257fa2f5892499c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a222d17a2b10e551d257fa2f5892499c)) return false;
return (this == (RC_a222d17a2b10e551d257fa2f5892499c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_a222d17a2b10e551d257fa2f5892499c Duplicate() {
RC_a222d17a2b10e551d257fa2f5892499c t;
t.ssENAccountingDataType = (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord)this.ssENAccountingDataType.Duplicate();
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
if (head == "accountingdatatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataType")) variable.Value = ssENAccountingDataType; else variable.Optimized = true;
variable.SetFieldName("accountingdatatype");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENAccountingDataType.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENAccountingDataType.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAccountingDataType) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccountingDataType.Key.AsGuid) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_a222d17a2b10e551d257fa2f5892499c
/// <summary>
/// RecordList type <code>AccountingDataTypeRecordList</code> that represents a record list of
///  <code>AccountingDataType</code>
/// </summary>
public partial class RL_d567d658fa66fc955f880e37985e7f35 : GenericRecordList<RC_a222d17a2b10e551d257fa2f5892499c>, IEnumerable, IEnumerator {

protected override RC_a222d17a2b10e551d257fa2f5892499c GetElementDefaultValue() {
return new RC_a222d17a2b10e551d257fa2f5892499c();
}

public T[] ToArray<T>(Func<RC_a222d17a2b10e551d257fa2f5892499c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d567d658fa66fc955f880e37985e7f35 recordList, Func<RC_a222d17a2b10e551d257fa2f5892499c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d567d658fa66fc955f880e37985e7f35(RC_a222d17a2b10e551d257fa2f5892499c[] array) {
  RL_d567d658fa66fc955f880e37985e7f35 result = new RL_d567d658fa66fc955f880e37985e7f35();
result.InnerFromArray(array);
    return result;
}

public static RL_d567d658fa66fc955f880e37985e7f35 ToList<T>(T[] array, Func <T, RC_a222d17a2b10e551d257fa2f5892499c> converter) {
  RL_d567d658fa66fc955f880e37985e7f35 result = new RL_d567d658fa66fc955f880e37985e7f35();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d567d658fa66fc955f880e37985e7f35 FromRestList<T>(RestList<T> restList, Func <T, RC_a222d17a2b10e551d257fa2f5892499c> converter) {
  RL_d567d658fa66fc955f880e37985e7f35 result = new RL_d567d658fa66fc955f880e37985e7f35();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d567d658fa66fc955f880e37985e7f35() : base() {
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
protected override OSList<RC_a222d17a2b10e551d257fa2f5892499c> NewList() {
return new RL_d567d658fa66fc955f880e37985e7f35();
}


} // RL_d567d658fa66fc955f880e37985e7f35
}

