namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Uc7mV8NwdE6DqPLAqcRhdg)
///  <code>RC_306956f424b25ba445c85694148eaa7a</code> that represent
/// s <code>InvoiceInvoice_CNInvoiceStatusFolioOrderMainSupplierRegionRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: InvoiceInvoice_CNInvoiceStatusFolioOrderMainSupplierRegionRecord
public partial struct RC_306956f424b25ba445c85694148eaa7a : ITypedRecord<RC_306956f424b25ba445c85694148eaa7a> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoice_CN = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*H_R5HZrmYoYC9Pq5rdjlpw");
internal static readonly GlobalObjectKey IdInvoiceStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xRfbbmO_L0X0rCTUGZGpQA");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice_CN;

public EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord ssENInvoiceStatus;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_306956f424b25ba445c85694148eaa7a() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoice_CN = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceStatus = new EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[7];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(7,false);
    all[3] = new BitArray(20,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(28,false);
    all[6] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice_CN.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceStatus.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoice_CN.OptimizedAttributes = value[1];
    ssENInvoiceStatus.OptimizedAttributes = value[2];
    ssENFolio.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENSupplier.OptimizedAttributes = value[5];
    ssENRegion.OptimizedAttributes = value[6];
    }
}
get{
    BitArray[] all = new BitArray[7];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoice_CN.OptimizedAttributes;
    all[2] = ssENInvoiceStatus.OptimizedAttributes;
    all[3] = ssENFolio.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENSupplier.OptimizedAttributes;
    all[6] = ssENRegion.OptimizedAttributes;
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
ssENInvoice_CN.Read( r, ref index);
ssENInvoiceStatus.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_306956f424b25ba445c85694148eaa7a r) {
this = r;
}


public static bool operator == (RC_306956f424b25ba445c85694148eaa7a a, RC_306956f424b25ba445c85694148eaa7a b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoice_CN != b.ssENInvoice_CN) return false;
if (a.ssENInvoiceStatus != b.ssENInvoiceStatus) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_306956f424b25ba445c85694148eaa7a a, RC_306956f424b25ba445c85694148eaa7a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_306956f424b25ba445c85694148eaa7a)) return false;
return (this == (RC_306956f424b25ba445c85694148eaa7a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoice_CN.GetHashCode()
 ^ ssENInvoiceStatus.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoice_CN.RecursiveReset();
ssENInvoiceStatus.RecursiveReset();
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoice_CN.InternalRecursiveSave();
ssENInvoiceStatus.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_306956f424b25ba445c85694148eaa7a Duplicate() {
RC_306956f424b25ba445c85694148eaa7a t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoice_CN = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice_CN.Duplicate();
t.ssENInvoiceStatus = (EN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord)this.ssENInvoiceStatus.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
} else if (head == "invoice_cn") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice_CN")) variable.Value = ssENInvoice_CN; else variable.Optimized = true;
variable.SetFieldName("invoice_cn");
} else if (head == "invoicestatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceStatus")) variable.Value = ssENInvoiceStatus; else variable.Optimized = true;
variable.SetFieldName("invoicestatus");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdInvoice_CN) {
return ssENInvoice_CN;
}
if (key == IdInvoiceStatus) {
return ssENInvoiceStatus;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
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
if (attributeKey == IdInvoice_CN.Key.AsGuid) {
return ssENInvoice_CN;
}
if (attributeKey == IdInvoiceStatus.Key.AsGuid) {
return ssENInvoiceStatus;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
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
ssENInvoice_CN.FillFromOther((IRecord) other.AttributeGet(IdInvoice_CN));
ssENInvoiceStatus.FillFromOther((IRecord) other.AttributeGet(IdInvoiceStatus));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_306956f424b25ba445c85694148eaa7a
/// <summary>
/// RecordList type <code>InvoiceInvoice_CNInvoiceStatusFolioOrderMainSupplierRegionRecordList</code>
///  that represents a record list of <code>Invoice, Invoice, InvoiceStatus, Folio, OrderMain, Supplier
/// , Region</code>
/// </summary>
public partial class RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 : GenericRecordList<RC_306956f424b25ba445c85694148eaa7a>, IEnumerable, IEnumerator {

protected override RC_306956f424b25ba445c85694148eaa7a GetElementDefaultValue() {
return new RC_306956f424b25ba445c85694148eaa7a();
}

public T[] ToArray<T>(Func<RC_306956f424b25ba445c85694148eaa7a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 recordList, Func<RC_306956f424b25ba445c85694148eaa7a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a9ef13a7afdd5c93ea6dfe986c3c8b78(RC_306956f424b25ba445c85694148eaa7a[] array) {
  RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 result = new RL_a9ef13a7afdd5c93ea6dfe986c3c8b78();
result.InnerFromArray(array);
    return result;
}

public static RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 ToList<T>(T[] array, Func <T, RC_306956f424b25ba445c85694148eaa7a> converter) {
  RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 result = new RL_a9ef13a7afdd5c93ea6dfe986c3c8b78();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 FromRestList<T>(RestList<T> restList, Func <T, RC_306956f424b25ba445c85694148eaa7a> converter) {
  RL_a9ef13a7afdd5c93ea6dfe986c3c8b78 result = new RL_a9ef13a7afdd5c93ea6dfe986c3c8b78();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a9ef13a7afdd5c93ea6dfe986c3c8b78() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[7];
def[0] = new BitArray(24,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(7,false);
def[3] = new BitArray(20,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(28,false);
def[6] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_306956f424b25ba445c85694148eaa7a> NewList() {
return new RL_a9ef13a7afdd5c93ea6dfe986c3c8b78();
}


} // RL_a9ef13a7afdd5c93ea6dfe986c3c8b78
}

