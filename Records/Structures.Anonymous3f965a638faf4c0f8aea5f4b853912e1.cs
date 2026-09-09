namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Y1qWP6+PD0yK6l9LhTkS4Q)
///  <code>RC_bbceb04a99cf02c4edcf63fc8b805b9f</code> that represent
/// s <code>InvoiceFolioRequisitionOrderMainSupplierFolioSupplierOrderSupplierReqRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceFolioRequisitionOrderMainSupplierFolioSupplierOrderSupplierReqRecord
public partial struct RC_bbceb04a99cf02c4edcf63fc8b805b9f : ITypedRecord<RC_bbceb04a99cf02c4edcf63fc8b805b9f> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplierFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*vPZm4tqw3Y7nYrFX938a_A");
internal static readonly GlobalObjectKey IdSupplierOrder = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*9+ec7VxcwLMIarndMJ2rAw");
internal static readonly GlobalObjectKey IdSupplierReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*3WPQaH9ndXar8O9ClLY9Tg");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplierFolio;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplierOrder;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplierReq;


public BitArray OptimizedAttributes;

public RC_bbceb04a99cf02c4edcf63fc8b805b9f() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplierFolio = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENSupplierOrder = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENSupplierReq = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(29,false);
    all[4] = new BitArray(28,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplierFolio.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplierOrder.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplierReq.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENOrderMain.OptimizedAttributes = value[3];
    ssENSupplierFolio.OptimizedAttributes = value[4];
    ssENSupplierOrder.OptimizedAttributes = value[5];
    ssENSupplierReq.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENOrderMain.OptimizedAttributes;
    all[4] = ssENSupplierFolio.OptimizedAttributes;
    all[5] = ssENSupplierOrder.OptimizedAttributes;
    all[6] = ssENSupplierReq.OptimizedAttributes;
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
ssENFolio.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENSupplierFolio.Read( r, ref index);
ssENSupplierOrder.Read( r, ref index);
ssENSupplierReq.Read( r, ref index);
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
public void ReadIM(RC_bbceb04a99cf02c4edcf63fc8b805b9f r) {
this = r;
}


public static bool operator == (RC_bbceb04a99cf02c4edcf63fc8b805b9f a, RC_bbceb04a99cf02c4edcf63fc8b805b9f b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplierFolio != b.ssENSupplierFolio) return false;
if (a.ssENSupplierOrder != b.ssENSupplierOrder) return false;
if (a.ssENSupplierReq != b.ssENSupplierReq) return false;
return true;
}

public static bool operator != (RC_bbceb04a99cf02c4edcf63fc8b805b9f a, RC_bbceb04a99cf02c4edcf63fc8b805b9f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bbceb04a99cf02c4edcf63fc8b805b9f)) return false;
return (this == (RC_bbceb04a99cf02c4edcf63fc8b805b9f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplierFolio.GetHashCode()
 ^ ssENSupplierOrder.GetHashCode()
 ^ ssENSupplierReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplierFolio.RecursiveReset();
ssENSupplierOrder.RecursiveReset();
ssENSupplierReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplierFolio.InternalRecursiveSave();
ssENSupplierOrder.InternalRecursiveSave();
ssENSupplierReq.InternalRecursiveSave();
}


public RC_bbceb04a99cf02c4edcf63fc8b805b9f Duplicate() {
RC_bbceb04a99cf02c4edcf63fc8b805b9f t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENSupplierFolio = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplierFolio.Duplicate();
t.ssENSupplierOrder = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplierOrder.Duplicate();
t.ssENSupplierReq = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplierReq.Duplicate();
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
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "supplierfolio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierFolio")) variable.Value = ssENSupplierFolio; else variable.Optimized = true;
variable.SetFieldName("supplierfolio");
} else if (head == "supplierorder") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierOrder")) variable.Value = ssENSupplierOrder; else variable.Optimized = true;
variable.SetFieldName("supplierorder");
} else if (head == "supplierreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierReq")) variable.Value = ssENSupplierReq; else variable.Optimized = true;
variable.SetFieldName("supplierreq");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdSupplierFolio) {
return ssENSupplierFolio;
}
if (key == IdSupplierOrder) {
return ssENSupplierOrder;
}
if (key == IdSupplierReq) {
return ssENSupplierReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdSupplierFolio.Key.AsGuid) {
return ssENSupplierFolio;
}
if (attributeKey == IdSupplierOrder.Key.AsGuid) {
return ssENSupplierOrder;
}
if (attributeKey == IdSupplierReq.Key.AsGuid) {
return ssENSupplierReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplierFolio.FillFromOther((IRecord) other.AttributeGet(IdSupplierFolio));
ssENSupplierOrder.FillFromOther((IRecord) other.AttributeGet(IdSupplierOrder));
ssENSupplierReq.FillFromOther((IRecord) other.AttributeGet(IdSupplierReq));
}
} // RC_bbceb04a99cf02c4edcf63fc8b805b9f
/// <summary>
/// RecordList type
///  <code>InvoiceFolioRequisitionOrderMainSupplierFolioSupplierOrderSupplierReqRecordList</code> tha
/// t represents a record list of <code>Invoice, Folio, Requisition, OrderMain, Supplier, Supplier,
///  Supplier</code>
/// </summary>
public partial class RL_57f9395b59a284b640e8ea9444ea4ae8 : GenericRecordList<RC_bbceb04a99cf02c4edcf63fc8b805b9f>, IEnumerable, IEnumerator {

protected override RC_bbceb04a99cf02c4edcf63fc8b805b9f GetElementDefaultValue() {
return new RC_bbceb04a99cf02c4edcf63fc8b805b9f();
}

public T[] ToArray<T>(Func<RC_bbceb04a99cf02c4edcf63fc8b805b9f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_57f9395b59a284b640e8ea9444ea4ae8 recordList, Func<RC_bbceb04a99cf02c4edcf63fc8b805b9f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_57f9395b59a284b640e8ea9444ea4ae8(RC_bbceb04a99cf02c4edcf63fc8b805b9f[] array) {
  RL_57f9395b59a284b640e8ea9444ea4ae8 result = new RL_57f9395b59a284b640e8ea9444ea4ae8();
result.InnerFromArray(array);
    return result;
}

public static RL_57f9395b59a284b640e8ea9444ea4ae8 ToList<T>(T[] array, Func <T, RC_bbceb04a99cf02c4edcf63fc8b805b9f> converter) {
  RL_57f9395b59a284b640e8ea9444ea4ae8 result = new RL_57f9395b59a284b640e8ea9444ea4ae8();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_57f9395b59a284b640e8ea9444ea4ae8 FromRestList<T>(RestList<T> restList, Func <T, RC_bbceb04a99cf02c4edcf63fc8b805b9f> converter) {
  RL_57f9395b59a284b640e8ea9444ea4ae8 result = new RL_57f9395b59a284b640e8ea9444ea4ae8();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_57f9395b59a284b640e8ea9444ea4ae8() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(24,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(29,false);
def[4] = new BitArray(28,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bbceb04a99cf02c4edcf63fc8b805b9f> NewList() {
return new RL_57f9395b59a284b640e8ea9444ea4ae8();
}


} // RL_57f9395b59a284b640e8ea9444ea4ae8
}

