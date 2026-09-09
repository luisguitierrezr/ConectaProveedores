namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (CYjZvjegFEyivMPa3NM10w)
///  <code>RC_9c686b5cc2dbfdbcbef82bc4cdcc5012</code> that represent
/// s <code>InvoiceOrderMainInvoiceExtendedCompanySupplierRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceOrderMainInvoiceExtendedCompanySupplierRegionRecord
public partial struct RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 : ITypedRecord<RC_9c686b5cc2dbfdbcbef82bc4cdcc5012> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_9c686b5cc2dbfdbcbef82bc4cdcc5012() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(19,false);
    all[3] = new BitArray(11,false);
    all[4] = new BitArray(28,false);
    all[5] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENInvoiceExtended.OptimizedAttributes = value[2];
    ssENCompany.OptimizedAttributes = value[3];
    ssENSupplier.OptimizedAttributes = value[4];
    ssENRegion.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    all[2] = ssENInvoiceExtended.OptimizedAttributes;
    all[3] = ssENCompany.OptimizedAttributes;
    all[4] = ssENSupplier.OptimizedAttributes;
    all[5] = ssENRegion.OptimizedAttributes;
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
ssENOrderMain.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 r) {
this = r;
}


public static bool operator == (RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 a, RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 a, RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9c686b5cc2dbfdbcbef82bc4cdcc5012)) return false;
return (this == (RC_9c686b5cc2dbfdbcbef82bc4cdcc5012)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENCompany.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENCompany.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 Duplicate() {
RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
} else if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
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
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
if (key == IdCompany) {
return ssENCompany;
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
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
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
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_9c686b5cc2dbfdbcbef82bc4cdcc5012
/// <summary>
/// RecordList type <code>InvoiceOrderMainInvoiceExtendedCompanySupplierRegionRecordList</code> that
///  represents a record list of <code>Invoice, OrderMain, InvoiceExtended, Company, Supplier
/// , Region</code>
/// </summary>
public partial class RL_a3410adc467aca89c856451800f767c9 : GenericRecordList<RC_9c686b5cc2dbfdbcbef82bc4cdcc5012>, IEnumerable, IEnumerator {

protected override RC_9c686b5cc2dbfdbcbef82bc4cdcc5012 GetElementDefaultValue() {
return new RC_9c686b5cc2dbfdbcbef82bc4cdcc5012();
}

public T[] ToArray<T>(Func<RC_9c686b5cc2dbfdbcbef82bc4cdcc5012, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a3410adc467aca89c856451800f767c9 recordList, Func<RC_9c686b5cc2dbfdbcbef82bc4cdcc5012, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a3410adc467aca89c856451800f767c9(RC_9c686b5cc2dbfdbcbef82bc4cdcc5012[] array) {
  RL_a3410adc467aca89c856451800f767c9 result = new RL_a3410adc467aca89c856451800f767c9();
result.InnerFromArray(array);
    return result;
}

public static RL_a3410adc467aca89c856451800f767c9 ToList<T>(T[] array, Func <T, RC_9c686b5cc2dbfdbcbef82bc4cdcc5012> converter) {
  RL_a3410adc467aca89c856451800f767c9 result = new RL_a3410adc467aca89c856451800f767c9();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a3410adc467aca89c856451800f767c9 FromRestList<T>(RestList<T> restList, Func <T, RC_9c686b5cc2dbfdbcbef82bc4cdcc5012> converter) {
  RL_a3410adc467aca89c856451800f767c9 result = new RL_a3410adc467aca89c856451800f767c9();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a3410adc467aca89c856451800f767c9() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(24,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(19,false);
def[3] = new BitArray(11,false);
def[4] = new BitArray(28,false);
def[5] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9c686b5cc2dbfdbcbef82bc4cdcc5012> NewList() {
return new RL_a3410adc467aca89c856451800f767c9();
}


} // RL_a3410adc467aca89c856451800f767c9
}

