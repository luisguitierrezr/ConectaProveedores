namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (YgvUolNKkkm5_Tt07I6hGA)
///  <code>RC_93224f6033b2fcf15869e73d67c629f2</code> that represent
/// s <code>FolioSAPDataInvoiceFolioInvoiceExtendedRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioSAPDataInvoiceFolioInvoiceExtendedRecord
public partial struct RC_93224f6033b2fcf15869e73d67c629f2 : ITypedRecord<RC_93224f6033b2fcf15869e73d67c629f2> {
internal static readonly GlobalObjectKey IdFolioSAPData = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*xIbSf5GGFjMBxQJ1gK5a9Q");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");

public EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord ssENFolioSAPData;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;


public BitArray OptimizedAttributes;

public RC_93224f6033b2fcf15869e73d67c629f2() {
OptimizedAttributes = null;
ssENFolioSAPData = new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(15,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolioSAPData.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENFolioSAPData.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENInvoiceExtended.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENFolioSAPData.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENInvoiceExtended.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolioSAPData.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
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
public void ReadIM(RC_93224f6033b2fcf15869e73d67c629f2 r) {
this = r;
}


public static bool operator == (RC_93224f6033b2fcf15869e73d67c629f2 a, RC_93224f6033b2fcf15869e73d67c629f2 b) {
if (a.ssENFolioSAPData != b.ssENFolioSAPData) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
return true;
}

public static bool operator != (RC_93224f6033b2fcf15869e73d67c629f2 a, RC_93224f6033b2fcf15869e73d67c629f2 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_93224f6033b2fcf15869e73d67c629f2)) return false;
return (this == (RC_93224f6033b2fcf15869e73d67c629f2)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolioSAPData.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolioSAPData.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolioSAPData.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
}


public RC_93224f6033b2fcf15869e73d67c629f2 Duplicate() {
RC_93224f6033b2fcf15869e73d67c629f2 t;
t.ssENFolioSAPData = (EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord)this.ssENFolioSAPData.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
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
if (head == "foliosapdata") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioSAPData")) variable.Value = ssENFolioSAPData; else variable.Optimized = true;
variable.SetFieldName("foliosapdata");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
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
if (key == IdFolioSAPData) {
return ssENFolioSAPData;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolioSAPData.Key.AsGuid) {
return ssENFolioSAPData;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolioSAPData.FillFromOther((IRecord) other.AttributeGet(IdFolioSAPData));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
}
} // RC_93224f6033b2fcf15869e73d67c629f2
/// <summary>
/// RecordList type <code>FolioSAPDataInvoiceFolioInvoiceExtendedRecordList</code> that represents a
///  record list of <code>FolioSAPData, Invoice, Folio, InvoiceExtended</code>
/// </summary>
public partial class RL_efc8890c0dc23aed40151f44dac99602 : GenericRecordList<RC_93224f6033b2fcf15869e73d67c629f2>, IEnumerable, IEnumerator {

protected override RC_93224f6033b2fcf15869e73d67c629f2 GetElementDefaultValue() {
return new RC_93224f6033b2fcf15869e73d67c629f2();
}

public T[] ToArray<T>(Func<RC_93224f6033b2fcf15869e73d67c629f2, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_efc8890c0dc23aed40151f44dac99602 recordList, Func<RC_93224f6033b2fcf15869e73d67c629f2, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_efc8890c0dc23aed40151f44dac99602(RC_93224f6033b2fcf15869e73d67c629f2[] array) {
  RL_efc8890c0dc23aed40151f44dac99602 result = new RL_efc8890c0dc23aed40151f44dac99602();
result.InnerFromArray(array);
    return result;
}

public static RL_efc8890c0dc23aed40151f44dac99602 ToList<T>(T[] array, Func <T, RC_93224f6033b2fcf15869e73d67c629f2> converter) {
  RL_efc8890c0dc23aed40151f44dac99602 result = new RL_efc8890c0dc23aed40151f44dac99602();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_efc8890c0dc23aed40151f44dac99602 FromRestList<T>(RestList<T> restList, Func <T, RC_93224f6033b2fcf15869e73d67c629f2> converter) {
  RL_efc8890c0dc23aed40151f44dac99602 result = new RL_efc8890c0dc23aed40151f44dac99602();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_efc8890c0dc23aed40151f44dac99602() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(15,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_93224f6033b2fcf15869e73d67c629f2> NewList() {
return new RL_efc8890c0dc23aed40151f44dac99602();
}


} // RL_efc8890c0dc23aed40151f44dac99602
}

