namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (6v9R0jBFE0+2QSNXHwR5Ng)
///  <code>RC_27125ab538212d639b6d08211936027a</code> that represent
/// s <code>OrderAccConceptsOrderAccountingAccountingDataTypeRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderAccConceptsOrderAccountingAccountingDataTypeRecord
public partial struct RC_27125ab538212d639b6d08211936027a : ITypedRecord<RC_27125ab538212d639b6d08211936027a> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public BitArray OptimizedAttributes;

public RC_27125ab538212d639b6d08211936027a() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(19,false);
    all[2] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    ssENOrderAccounting.OptimizedAttributes = value[1];
    ssENAccountingDataType.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
    all[1] = ssENOrderAccounting.OptimizedAttributes;
    all[2] = ssENAccountingDataType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderAccConcepts.Read( r, ref index);
ssENOrderAccounting.Read( r, ref index);
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
public void ReadIM(RC_27125ab538212d639b6d08211936027a r) {
this = r;
}


public static bool operator == (RC_27125ab538212d639b6d08211936027a a, RC_27125ab538212d639b6d08211936027a b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_27125ab538212d639b6d08211936027a a, RC_27125ab538212d639b6d08211936027a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_27125ab538212d639b6d08211936027a)) return false;
return (this == (RC_27125ab538212d639b6d08211936027a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
ssENOrderAccounting.RecursiveReset();
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
ssENOrderAccounting.InternalRecursiveSave();
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_27125ab538212d639b6d08211936027a Duplicate() {
RC_27125ab538212d639b6d08211936027a t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
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
if (head == "orderaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConcepts")) variable.Value = ssENOrderAccConcepts; else variable.Optimized = true;
variable.SetFieldName("orderaccconcepts");
} else if (head == "orderaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccounting")) variable.Value = ssENOrderAccounting; else variable.Optimized = true;
variable.SetFieldName("orderaccounting");
} else if (head == "accountingdatatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataType")) variable.Value = ssENAccountingDataType; else variable.Optimized = true;
variable.SetFieldName("accountingdatatype");
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
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
if (key == IdOrderAccounting) {
return ssENOrderAccounting;
}
if (key == IdAccountingDataType) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdOrderAccounting.Key.AsGuid) {
return ssENOrderAccounting;
}
if (attributeKey == IdAccountingDataType.Key.AsGuid) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENOrderAccounting.FillFromOther((IRecord) other.AttributeGet(IdOrderAccounting));
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_27125ab538212d639b6d08211936027a
/// <summary>
/// RecordList type <code>OrderAccConceptsOrderAccountingAccountingDataTypeRecordList</code> that
///  represents a record list of <code>OrderAccConcepts, OrderAccounting, AccountingDataType</code>
/// </summary>
public partial class RL_fe2a66f29d923f08aaf84e90873f4cc6 : GenericRecordList<RC_27125ab538212d639b6d08211936027a>, IEnumerable, IEnumerator {

protected override RC_27125ab538212d639b6d08211936027a GetElementDefaultValue() {
return new RC_27125ab538212d639b6d08211936027a();
}

public T[] ToArray<T>(Func<RC_27125ab538212d639b6d08211936027a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fe2a66f29d923f08aaf84e90873f4cc6 recordList, Func<RC_27125ab538212d639b6d08211936027a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fe2a66f29d923f08aaf84e90873f4cc6(RC_27125ab538212d639b6d08211936027a[] array) {
  RL_fe2a66f29d923f08aaf84e90873f4cc6 result = new RL_fe2a66f29d923f08aaf84e90873f4cc6();
result.InnerFromArray(array);
    return result;
}

public static RL_fe2a66f29d923f08aaf84e90873f4cc6 ToList<T>(T[] array, Func <T, RC_27125ab538212d639b6d08211936027a> converter) {
  RL_fe2a66f29d923f08aaf84e90873f4cc6 result = new RL_fe2a66f29d923f08aaf84e90873f4cc6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fe2a66f29d923f08aaf84e90873f4cc6 FromRestList<T>(RestList<T> restList, Func <T, RC_27125ab538212d639b6d08211936027a> converter) {
  RL_fe2a66f29d923f08aaf84e90873f4cc6 result = new RL_fe2a66f29d923f08aaf84e90873f4cc6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fe2a66f29d923f08aaf84e90873f4cc6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(14,false);
def[1] = new BitArray(19,false);
def[2] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_27125ab538212d639b6d08211936027a> NewList() {
return new RL_fe2a66f29d923f08aaf84e90873f4cc6();
}


} // RL_fe2a66f29d923f08aaf84e90873f4cc6
}

