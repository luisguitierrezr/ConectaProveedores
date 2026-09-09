namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nOepiHqFI0+8t3iCvZCbAQ)
///  <code>RC_42a47f09e8ab03d8e9c2d1f2f5aa06af</code> that represent
/// s <code>InvoiceInvoiceStatusRequisitionSupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceStatusRequisitionSupplierRegionRecord
public partial struct RC_42a47f09e8ab03d8e9c2d1f2f5aa06af : ITypedRecord<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_42a47f09e8ab03d8e9c2d1f2f5aa06af() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(7,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(28,false);
    all[4] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceStatus.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENSupplier.OptimizedAttributes = value[3];
    ssENRegion.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceStatus.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENSupplier.OptimizedAttributes;
    all[4] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_42a47f09e8ab03d8e9c2d1f2f5aa06af r) {
this = r;
}


public static bool operator == (RC_42a47f09e8ab03d8e9c2d1f2f5aa06af a, RC_42a47f09e8ab03d8e9c2d1f2f5aa06af b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_42a47f09e8ab03d8e9c2d1f2f5aa06af a, RC_42a47f09e8ab03d8e9c2d1f2f5aa06af b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_42a47f09e8ab03d8e9c2d1f2f5aa06af)) return false;
return (this == (RC_42a47f09e8ab03d8e9c2d1f2f5aa06af)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_42a47f09e8ab03d8e9c2d1f2f5aa06af Duplicate() {
RC_42a47f09e8ab03d8e9c2d1f2f5aa06af t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_42a47f09e8ab03d8e9c2d1f2f5aa06af
/// <summary>
/// RecordList type <code>InvoiceInvoiceStatusRequisitionSupplierRegionRecordList</code> that
///  represents a record list of <code>Invoice, InvoiceStatus, Requisition, Supplier, Region</code>
/// </summary>
public partial class RL_e6ad6603ac07123d4d7c5f1b4a760912 : GenericRecordList<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af>, IEnumerable, IEnumerator {

protected override RC_42a47f09e8ab03d8e9c2d1f2f5aa06af GetElementDefaultValue() {
return new RC_42a47f09e8ab03d8e9c2d1f2f5aa06af();
}

public T[] ToArray<T>(Func<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e6ad6603ac07123d4d7c5f1b4a760912 recordList, Func<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e6ad6603ac07123d4d7c5f1b4a760912(RC_42a47f09e8ab03d8e9c2d1f2f5aa06af[] array) {
  RL_e6ad6603ac07123d4d7c5f1b4a760912 result = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
result.InnerFromArray(array);
    return result;
}

public static RL_e6ad6603ac07123d4d7c5f1b4a760912 ToList<T>(T[] array, Func <T, RC_42a47f09e8ab03d8e9c2d1f2f5aa06af> converter) {
  RL_e6ad6603ac07123d4d7c5f1b4a760912 result = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e6ad6603ac07123d4d7c5f1b4a760912 FromRestList<T>(RestList<T> restList, Func <T, RC_42a47f09e8ab03d8e9c2d1f2f5aa06af> converter) {
  RL_e6ad6603ac07123d4d7c5f1b4a760912 result = new RL_e6ad6603ac07123d4d7c5f1b4a760912();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e6ad6603ac07123d4d7c5f1b4a760912() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(24,false);
def[1] = new BitArray(7,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(28,false);
def[4] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_42a47f09e8ab03d8e9c2d1f2f5aa06af> NewList() {
return new RL_e6ad6603ac07123d4d7c5f1b4a760912();
}


} // RL_e6ad6603ac07123d4d7c5f1b4a760912
}

