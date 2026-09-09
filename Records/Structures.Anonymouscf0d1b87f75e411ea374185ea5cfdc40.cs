namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (hxsNz173HkGjdBhepc_cQA)
///  <code>RC_d2afc71b0d41323d7c4b380eedf435e1</code> that represent
/// s <code>OrderMainItemInvoiceUsageRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemInvoiceUsageRecord
public partial struct RC_d2afc71b0d41323d7c4b380eedf435e1 : ITypedRecord<RC_d2afc71b0d41323d7c4b380eedf435e1> {
internal static readonly GlobalObjectKey IdOrderMainItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*fyDMxBeQTt4BP6vPHo6+rw");
internal static readonly GlobalObjectKey IdInvoiceUsage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PM0SJfnH44ZrTV7fKQ1Dgw");

public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord ssENOrderMainItem;

public EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord ssENInvoiceUsage;


public BitArray OptimizedAttributes;

public RC_d2afc71b0d41323d7c4b380eedf435e1() {
OptimizedAttributes = null;
ssENOrderMainItem = new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord();
ssENInvoiceUsage = new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(51,false);
    all[1] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceUsage.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrderMainItem.OptimizedAttributes = value[0];
    ssENInvoiceUsage.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrderMainItem.OptimizedAttributes;
    all[1] = ssENInvoiceUsage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMainItem.Read( r, ref index);
ssENInvoiceUsage.Read( r, ref index);
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
public void ReadIM(RC_d2afc71b0d41323d7c4b380eedf435e1 r) {
this = r;
}


public static bool operator == (RC_d2afc71b0d41323d7c4b380eedf435e1 a, RC_d2afc71b0d41323d7c4b380eedf435e1 b) {
if (a.ssENOrderMainItem != b.ssENOrderMainItem) return false;
if (a.ssENInvoiceUsage != b.ssENInvoiceUsage) return false;
return true;
}

public static bool operator != (RC_d2afc71b0d41323d7c4b380eedf435e1 a, RC_d2afc71b0d41323d7c4b380eedf435e1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d2afc71b0d41323d7c4b380eedf435e1)) return false;
return (this == (RC_d2afc71b0d41323d7c4b380eedf435e1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItem.GetHashCode()
 ^ ssENInvoiceUsage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItem.RecursiveReset();
ssENInvoiceUsage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItem.InternalRecursiveSave();
ssENInvoiceUsage.InternalRecursiveSave();
}


public RC_d2afc71b0d41323d7c4b380eedf435e1 Duplicate() {
RC_d2afc71b0d41323d7c4b380eedf435e1 t;
t.ssENOrderMainItem = (EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord)this.ssENOrderMainItem.Duplicate();
t.ssENInvoiceUsage = (EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord)this.ssENInvoiceUsage.Duplicate();
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
if (head == "ordermainitem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItem")) variable.Value = ssENOrderMainItem; else variable.Optimized = true;
variable.SetFieldName("ordermainitem");
} else if (head == "invoiceusage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceUsage")) variable.Value = ssENInvoiceUsage; else variable.Optimized = true;
variable.SetFieldName("invoiceusage");
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
if (key == IdOrderMainItem) {
return ssENOrderMainItem;
}
if (key == IdInvoiceUsage) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItem.Key.AsGuid) {
return ssENOrderMainItem;
}
if (attributeKey == IdInvoiceUsage.Key.AsGuid) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItem.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItem));
ssENInvoiceUsage.FillFromOther((IRecord) other.AttributeGet(IdInvoiceUsage));
}
} // RC_d2afc71b0d41323d7c4b380eedf435e1
/// <summary>
/// RecordList type <code>OrderMainItemInvoiceUsageRecordList</code> that represents a record list of
///  <code>OrderMainItem, InvoiceUsage</code>
/// </summary>
public partial class RL_a84836cbe605db9f376d25b795a14e12 : GenericRecordList<RC_d2afc71b0d41323d7c4b380eedf435e1>, IEnumerable, IEnumerator {

protected override RC_d2afc71b0d41323d7c4b380eedf435e1 GetElementDefaultValue() {
return new RC_d2afc71b0d41323d7c4b380eedf435e1();
}

public T[] ToArray<T>(Func<RC_d2afc71b0d41323d7c4b380eedf435e1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a84836cbe605db9f376d25b795a14e12 recordList, Func<RC_d2afc71b0d41323d7c4b380eedf435e1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a84836cbe605db9f376d25b795a14e12(RC_d2afc71b0d41323d7c4b380eedf435e1[] array) {
  RL_a84836cbe605db9f376d25b795a14e12 result = new RL_a84836cbe605db9f376d25b795a14e12();
result.InnerFromArray(array);
    return result;
}

public static RL_a84836cbe605db9f376d25b795a14e12 ToList<T>(T[] array, Func <T, RC_d2afc71b0d41323d7c4b380eedf435e1> converter) {
  RL_a84836cbe605db9f376d25b795a14e12 result = new RL_a84836cbe605db9f376d25b795a14e12();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a84836cbe605db9f376d25b795a14e12 FromRestList<T>(RestList<T> restList, Func <T, RC_d2afc71b0d41323d7c4b380eedf435e1> converter) {
  RL_a84836cbe605db9f376d25b795a14e12 result = new RL_a84836cbe605db9f376d25b795a14e12();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a84836cbe605db9f376d25b795a14e12() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(51,false);
def[1] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d2afc71b0d41323d7c4b380eedf435e1> NewList() {
return new RL_a84836cbe605db9f376d25b795a14e12();
}


} // RL_a84836cbe605db9f376d25b795a14e12
}

