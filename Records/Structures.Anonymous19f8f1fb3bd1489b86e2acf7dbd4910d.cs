namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (+_H4GdE7m0iG4qz329SRDQ)
///  <code>RC_f5e2444cde8ccebe1d8b8fbec7a36039</code> that represent
/// s <code>CurrencyInvoiceRequisitionInvoiceExtendedItemRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyInvoiceRequisitionInvoiceExtendedItemRecord
public partial struct RC_f5e2444cde8ccebe1d8b8fbec7a36039 : ITypedRecord<RC_f5e2444cde8ccebe1d8b8fbec7a36039> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceExtendedItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zxAmf18M2K1rp4yQLDHv+g");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem;


public BitArray OptimizedAttributes;

public RC_f5e2444cde8ccebe1d8b8fbec7a36039() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceExtendedItem = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceExtendedItem.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENInvoiceExtendedItem.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENInvoiceExtendedItem.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENInvoiceExtendedItem.Read( r, ref index);
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
public void ReadIM(RC_f5e2444cde8ccebe1d8b8fbec7a36039 r) {
this = r;
}


public static bool operator == (RC_f5e2444cde8ccebe1d8b8fbec7a36039 a, RC_f5e2444cde8ccebe1d8b8fbec7a36039 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceExtendedItem != b.ssENInvoiceExtendedItem) return false;
return true;
}

public static bool operator != (RC_f5e2444cde8ccebe1d8b8fbec7a36039 a, RC_f5e2444cde8ccebe1d8b8fbec7a36039 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f5e2444cde8ccebe1d8b8fbec7a36039)) return false;
return (this == (RC_f5e2444cde8ccebe1d8b8fbec7a36039)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceExtendedItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceExtendedItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceExtendedItem.InternalRecursiveSave();
}


public RC_f5e2444cde8ccebe1d8b8fbec7a36039 Duplicate() {
RC_f5e2444cde8ccebe1d8b8fbec7a36039 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceExtendedItem = (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)this.ssENInvoiceExtendedItem.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceextendeditem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItem")) variable.Value = ssENInvoiceExtendedItem; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditem");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceExtendedItem) {
return ssENInvoiceExtendedItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceExtendedItem.Key.AsGuid) {
return ssENInvoiceExtendedItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceExtendedItem.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItem));
}
} // RC_f5e2444cde8ccebe1d8b8fbec7a36039
/// <summary>
/// RecordList type <code>CurrencyInvoiceRequisitionInvoiceExtendedItemRecordList</code> that
///  represents a record list of <code>Currency, Invoice, Requisition, InvoiceExtendedItem</code>
/// </summary>
public partial class RL_e14179ee8651dc8cb6e49b70d6c98c9d : GenericRecordList<RC_f5e2444cde8ccebe1d8b8fbec7a36039>, IEnumerable, IEnumerator {

protected override RC_f5e2444cde8ccebe1d8b8fbec7a36039 GetElementDefaultValue() {
return new RC_f5e2444cde8ccebe1d8b8fbec7a36039();
}

public T[] ToArray<T>(Func<RC_f5e2444cde8ccebe1d8b8fbec7a36039, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e14179ee8651dc8cb6e49b70d6c98c9d recordList, Func<RC_f5e2444cde8ccebe1d8b8fbec7a36039, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e14179ee8651dc8cb6e49b70d6c98c9d(RC_f5e2444cde8ccebe1d8b8fbec7a36039[] array) {
  RL_e14179ee8651dc8cb6e49b70d6c98c9d result = new RL_e14179ee8651dc8cb6e49b70d6c98c9d();
result.InnerFromArray(array);
    return result;
}

public static RL_e14179ee8651dc8cb6e49b70d6c98c9d ToList<T>(T[] array, Func <T, RC_f5e2444cde8ccebe1d8b8fbec7a36039> converter) {
  RL_e14179ee8651dc8cb6e49b70d6c98c9d result = new RL_e14179ee8651dc8cb6e49b70d6c98c9d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e14179ee8651dc8cb6e49b70d6c98c9d FromRestList<T>(RestList<T> restList, Func <T, RC_f5e2444cde8ccebe1d8b8fbec7a36039> converter) {
  RL_e14179ee8651dc8cb6e49b70d6c98c9d result = new RL_e14179ee8651dc8cb6e49b70d6c98c9d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e14179ee8651dc8cb6e49b70d6c98c9d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f5e2444cde8ccebe1d8b8fbec7a36039> NewList() {
return new RL_e14179ee8651dc8cb6e49b70d6c98c9d();
}


} // RL_e14179ee8651dc8cb6e49b70d6c98c9d
}

