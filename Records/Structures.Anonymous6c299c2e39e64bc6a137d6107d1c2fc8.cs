namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (LpwpbOY5xkuhN9YQfRwvyA)
///  <code>RC_ab3c433102000c44a55e713fb2ce955d</code> that represent
/// s <code>OrderAccConceptsOrderAccountingOrderMainAccountingDataTypeRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: OrderAccConceptsOrderAccountingOrderMainAccountingDataTypeRecord
public partial struct RC_ab3c433102000c44a55e713fb2ce955d : ITypedRecord<RC_ab3c433102000c44a55e713fb2ce955d> {
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdOrderAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OM_CLcG8i2ozjcXqmlxkRg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord ssENOrderAccounting;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public BitArray OptimizedAttributes;

public RC_ab3c433102000c44a55e713fb2ce955d() {
OptimizedAttributes = null;
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(14,false);
    all[1] = new BitArray(19,false);
    all[2] = new BitArray(29,false);
    all[3] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENOrderAccConcepts.OptimizedAttributes = value[0];
    ssENOrderAccounting.OptimizedAttributes = value[1];
    ssENOrderMain.OptimizedAttributes = value[2];
    ssENAccountingDataType.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENOrderAccConcepts.OptimizedAttributes;
    all[1] = ssENOrderAccounting.OptimizedAttributes;
    all[2] = ssENOrderMain.OptimizedAttributes;
    all[3] = ssENAccountingDataType.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_ab3c433102000c44a55e713fb2ce955d r) {
this = r;
}


public static bool operator == (RC_ab3c433102000c44a55e713fb2ce955d a, RC_ab3c433102000c44a55e713fb2ce955d b) {
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENOrderAccounting != b.ssENOrderAccounting) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_ab3c433102000c44a55e713fb2ce955d a, RC_ab3c433102000c44a55e713fb2ce955d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ab3c433102000c44a55e713fb2ce955d)) return false;
return (this == (RC_ab3c433102000c44a55e713fb2ce955d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENOrderAccounting.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderAccConcepts.RecursiveReset();
ssENOrderAccounting.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderAccConcepts.InternalRecursiveSave();
ssENOrderAccounting.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_ab3c433102000c44a55e713fb2ce955d Duplicate() {
RC_ab3c433102000c44a55e713fb2ce955d t;
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENOrderAccounting = (EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord)this.ssENOrderAccounting.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdOrderMain) {
return ssENOrderMain;
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
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
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
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_ab3c433102000c44a55e713fb2ce955d
/// <summary>
/// RecordList type <code>OrderAccConceptsOrderAccountingOrderMainAccountingDataTypeRecordList</code>
///  that represents a record list of <code>OrderAccConcepts, OrderAccounting, OrderMain
/// , AccountingDataType</code>
/// </summary>
public partial class RL_c78a606a32d5fd9bcd75de1aae614727 : GenericRecordList<RC_ab3c433102000c44a55e713fb2ce955d>, IEnumerable, IEnumerator {

protected override RC_ab3c433102000c44a55e713fb2ce955d GetElementDefaultValue() {
return new RC_ab3c433102000c44a55e713fb2ce955d();
}

public T[] ToArray<T>(Func<RC_ab3c433102000c44a55e713fb2ce955d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c78a606a32d5fd9bcd75de1aae614727 recordList, Func<RC_ab3c433102000c44a55e713fb2ce955d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c78a606a32d5fd9bcd75de1aae614727(RC_ab3c433102000c44a55e713fb2ce955d[] array) {
  RL_c78a606a32d5fd9bcd75de1aae614727 result = new RL_c78a606a32d5fd9bcd75de1aae614727();
result.InnerFromArray(array);
    return result;
}

public static RL_c78a606a32d5fd9bcd75de1aae614727 ToList<T>(T[] array, Func <T, RC_ab3c433102000c44a55e713fb2ce955d> converter) {
  RL_c78a606a32d5fd9bcd75de1aae614727 result = new RL_c78a606a32d5fd9bcd75de1aae614727();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c78a606a32d5fd9bcd75de1aae614727 FromRestList<T>(RestList<T> restList, Func <T, RC_ab3c433102000c44a55e713fb2ce955d> converter) {
  RL_c78a606a32d5fd9bcd75de1aae614727 result = new RL_c78a606a32d5fd9bcd75de1aae614727();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c78a606a32d5fd9bcd75de1aae614727() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(14,false);
def[1] = new BitArray(19,false);
def[2] = new BitArray(29,false);
def[3] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ab3c433102000c44a55e713fb2ce955d> NewList() {
return new RL_c78a606a32d5fd9bcd75de1aae614727();
}


} // RL_c78a606a32d5fd9bcd75de1aae614727
}

