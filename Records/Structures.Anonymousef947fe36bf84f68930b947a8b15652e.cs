namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (43+U7_hraE+TC5R6ixVlLg)
///  <code>RC_6dd7b29a235be8701ea943f35694df35</code> that represent
/// s <code>RequisitionServiceInvoiceUsageRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionServiceInvoiceUsageRecord
public partial struct RC_6dd7b29a235be8701ea943f35694df35 : ITypedRecord<RC_6dd7b29a235be8701ea943f35694df35> {
internal static readonly GlobalObjectKey IdRequisitionService = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dyTnBAZXQA0WtDECEZsN1g");
internal static readonly GlobalObjectKey IdInvoiceUsage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PM0SJfnH44ZrTV7fKQ1Dgw");

public EN_455768e63ed34ad2746f7c539b65e1caEntityRecord ssENRequisitionService;

public EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord ssENInvoiceUsage;


public BitArray OptimizedAttributes;

public RC_6dd7b29a235be8701ea943f35694df35() {
OptimizedAttributes = null;
ssENRequisitionService = new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord();
ssENInvoiceUsage = new EN_4b4c014d751d32313a045df1c34bbf8fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(7,false);
    all[1] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionService.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceUsage.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionService.OptimizedAttributes = value[0];
    ssENInvoiceUsage.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionService.OptimizedAttributes;
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
ssENRequisitionService.Read( r, ref index);
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
public void ReadIM(RC_6dd7b29a235be8701ea943f35694df35 r) {
this = r;
}


public static bool operator == (RC_6dd7b29a235be8701ea943f35694df35 a, RC_6dd7b29a235be8701ea943f35694df35 b) {
if (a.ssENRequisitionService != b.ssENRequisitionService) return false;
if (a.ssENInvoiceUsage != b.ssENInvoiceUsage) return false;
return true;
}

public static bool operator != (RC_6dd7b29a235be8701ea943f35694df35 a, RC_6dd7b29a235be8701ea943f35694df35 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6dd7b29a235be8701ea943f35694df35)) return false;
return (this == (RC_6dd7b29a235be8701ea943f35694df35)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionService.GetHashCode()
 ^ ssENInvoiceUsage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionService.RecursiveReset();
ssENInvoiceUsage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionService.InternalRecursiveSave();
ssENInvoiceUsage.InternalRecursiveSave();
}


public RC_6dd7b29a235be8701ea943f35694df35 Duplicate() {
RC_6dd7b29a235be8701ea943f35694df35 t;
t.ssENRequisitionService = (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord)this.ssENRequisitionService.Duplicate();
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
if (head == "requisitionservice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionService")) variable.Value = ssENRequisitionService; else variable.Optimized = true;
variable.SetFieldName("requisitionservice");
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
if (key == IdRequisitionService) {
return ssENRequisitionService;
}
if (key == IdInvoiceUsage) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionService.Key.AsGuid) {
return ssENRequisitionService;
}
if (attributeKey == IdInvoiceUsage.Key.AsGuid) {
return ssENInvoiceUsage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionService.FillFromOther((IRecord) other.AttributeGet(IdRequisitionService));
ssENInvoiceUsage.FillFromOther((IRecord) other.AttributeGet(IdInvoiceUsage));
}
} // RC_6dd7b29a235be8701ea943f35694df35
/// <summary>
/// RecordList type <code>RequisitionServiceInvoiceUsageRecordList</code> that represents a record list
///  of <code>RequisitionService, InvoiceUsage</code>
/// </summary>
public partial class RL_ac28f3fb72f03b677713af175e2c8613 : GenericRecordList<RC_6dd7b29a235be8701ea943f35694df35>, IEnumerable, IEnumerator {

protected override RC_6dd7b29a235be8701ea943f35694df35 GetElementDefaultValue() {
return new RC_6dd7b29a235be8701ea943f35694df35();
}

public T[] ToArray<T>(Func<RC_6dd7b29a235be8701ea943f35694df35, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ac28f3fb72f03b677713af175e2c8613 recordList, Func<RC_6dd7b29a235be8701ea943f35694df35, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ac28f3fb72f03b677713af175e2c8613(RC_6dd7b29a235be8701ea943f35694df35[] array) {
  RL_ac28f3fb72f03b677713af175e2c8613 result = new RL_ac28f3fb72f03b677713af175e2c8613();
result.InnerFromArray(array);
    return result;
}

public static RL_ac28f3fb72f03b677713af175e2c8613 ToList<T>(T[] array, Func <T, RC_6dd7b29a235be8701ea943f35694df35> converter) {
  RL_ac28f3fb72f03b677713af175e2c8613 result = new RL_ac28f3fb72f03b677713af175e2c8613();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ac28f3fb72f03b677713af175e2c8613 FromRestList<T>(RestList<T> restList, Func <T, RC_6dd7b29a235be8701ea943f35694df35> converter) {
  RL_ac28f3fb72f03b677713af175e2c8613 result = new RL_ac28f3fb72f03b677713af175e2c8613();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ac28f3fb72f03b677713af175e2c8613() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(7,false);
def[1] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6dd7b29a235be8701ea943f35694df35> NewList() {
return new RL_ac28f3fb72f03b677713af175e2c8613();
}


} // RL_ac28f3fb72f03b677713af175e2c8613
}

