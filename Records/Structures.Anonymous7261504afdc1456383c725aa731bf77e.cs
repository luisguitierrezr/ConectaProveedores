namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SlBhcsH9Y0WDxyWqcxv3fg)
///  <code>RC_a23c38bc44b370f52521e410e49fc2ac</code> that represent
/// s <code>InvoiceFolioInvoiceExtendedRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceFolioInvoiceExtendedRecord
public partial struct RC_a23c38bc44b370f52521e410e49fc2ac : ITypedRecord<RC_a23c38bc44b370f52521e410e49fc2ac> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;


public BitArray OptimizedAttributes;

public RC_a23c38bc44b370f52521e410e49fc2ac() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENInvoiceExtended.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENInvoiceExtended.OptimizedAttributes;
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
public void ReadIM(RC_a23c38bc44b370f52521e410e49fc2ac r) {
this = r;
}


public static bool operator == (RC_a23c38bc44b370f52521e410e49fc2ac a, RC_a23c38bc44b370f52521e410e49fc2ac b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
return true;
}

public static bool operator != (RC_a23c38bc44b370f52521e410e49fc2ac a, RC_a23c38bc44b370f52521e410e49fc2ac b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a23c38bc44b370f52521e410e49fc2ac)) return false;
return (this == (RC_a23c38bc44b370f52521e410e49fc2ac)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
}


public RC_a23c38bc44b370f52521e410e49fc2ac Duplicate() {
RC_a23c38bc44b370f52521e410e49fc2ac t;
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
if (head == "invoice") {
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
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
}
} // RC_a23c38bc44b370f52521e410e49fc2ac
/// <summary>
/// RecordList type <code>InvoiceFolioInvoiceExtendedRecordList</code> that represents a record list of
///  <code>Invoice, Folio, InvoiceExtended</code>
/// </summary>
public partial class RL_547e7f54f784bcf7e09ead39e9929460 : GenericRecordList<RC_a23c38bc44b370f52521e410e49fc2ac>, IEnumerable, IEnumerator {

protected override RC_a23c38bc44b370f52521e410e49fc2ac GetElementDefaultValue() {
return new RC_a23c38bc44b370f52521e410e49fc2ac();
}

public T[] ToArray<T>(Func<RC_a23c38bc44b370f52521e410e49fc2ac, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_547e7f54f784bcf7e09ead39e9929460 recordList, Func<RC_a23c38bc44b370f52521e410e49fc2ac, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_547e7f54f784bcf7e09ead39e9929460(RC_a23c38bc44b370f52521e410e49fc2ac[] array) {
  RL_547e7f54f784bcf7e09ead39e9929460 result = new RL_547e7f54f784bcf7e09ead39e9929460();
result.InnerFromArray(array);
    return result;
}

public static RL_547e7f54f784bcf7e09ead39e9929460 ToList<T>(T[] array, Func <T, RC_a23c38bc44b370f52521e410e49fc2ac> converter) {
  RL_547e7f54f784bcf7e09ead39e9929460 result = new RL_547e7f54f784bcf7e09ead39e9929460();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_547e7f54f784bcf7e09ead39e9929460 FromRestList<T>(RestList<T> restList, Func <T, RC_a23c38bc44b370f52521e410e49fc2ac> converter) {
  RL_547e7f54f784bcf7e09ead39e9929460 result = new RL_547e7f54f784bcf7e09ead39e9929460();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_547e7f54f784bcf7e09ead39e9929460() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_a23c38bc44b370f52521e410e49fc2ac> NewList() {
return new RL_547e7f54f784bcf7e09ead39e9929460();
}


} // RL_547e7f54f784bcf7e09ead39e9929460
}

