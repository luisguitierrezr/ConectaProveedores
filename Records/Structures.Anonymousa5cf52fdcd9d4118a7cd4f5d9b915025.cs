namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (_VLPpZ3NGEGnzU9dm5FQJQ)
///  <code>RC_25d357c844d16eb6579210aff3596f77</code> that represent
/// s <code>InvoiceExtendedItemInvoiceExtendedItemTaxRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedItemInvoiceExtendedItemTaxRecord
public partial struct RC_25d357c844d16eb6579210aff3596f77 : ITypedRecord<RC_25d357c844d16eb6579210aff3596f77> {
internal static readonly GlobalObjectKey IdInvoiceExtendedItem = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*zxAmf18M2K1rp4yQLDHv+g");
internal static readonly GlobalObjectKey IdInvoiceExtendedItemTax = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OeG059VGpGiO85tqO_zllQ");

public EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord ssENInvoiceExtendedItem;

public EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord ssENInvoiceExtendedItemTax;


public BitArray OptimizedAttributes;

public RC_25d357c844d16eb6579210aff3596f77() {
OptimizedAttributes = null;
ssENInvoiceExtendedItem = new EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord();
ssENInvoiceExtendedItemTax = new EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedItem.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceExtendedItemTax.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceExtendedItem.OptimizedAttributes = value[0];
    ssENInvoiceExtendedItemTax.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceExtendedItem.OptimizedAttributes;
    all[1] = ssENInvoiceExtendedItemTax.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedItem.Read( r, ref index);
ssENInvoiceExtendedItemTax.Read( r, ref index);
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
public void ReadIM(RC_25d357c844d16eb6579210aff3596f77 r) {
this = r;
}


public static bool operator == (RC_25d357c844d16eb6579210aff3596f77 a, RC_25d357c844d16eb6579210aff3596f77 b) {
if (a.ssENInvoiceExtendedItem != b.ssENInvoiceExtendedItem) return false;
if (a.ssENInvoiceExtendedItemTax != b.ssENInvoiceExtendedItemTax) return false;
return true;
}

public static bool operator != (RC_25d357c844d16eb6579210aff3596f77 a, RC_25d357c844d16eb6579210aff3596f77 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_25d357c844d16eb6579210aff3596f77)) return false;
return (this == (RC_25d357c844d16eb6579210aff3596f77)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedItem.GetHashCode()
 ^ ssENInvoiceExtendedItemTax.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedItem.RecursiveReset();
ssENInvoiceExtendedItemTax.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedItem.InternalRecursiveSave();
ssENInvoiceExtendedItemTax.InternalRecursiveSave();
}


public RC_25d357c844d16eb6579210aff3596f77 Duplicate() {
RC_25d357c844d16eb6579210aff3596f77 t;
t.ssENInvoiceExtendedItem = (EN_053332cfe78d04ad15b32ae1d06e5a70EntityRecord)this.ssENInvoiceExtendedItem.Duplicate();
t.ssENInvoiceExtendedItemTax = (EN_ac8f182513b48d814f8a265614e7c7c2EntityRecord)this.ssENInvoiceExtendedItemTax.Duplicate();
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
if (head == "invoiceextendeditem") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItem")) variable.Value = ssENInvoiceExtendedItem; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditem");
} else if (head == "invoiceextendeditemtax") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedItemTax")) variable.Value = ssENInvoiceExtendedItemTax; else variable.Optimized = true;
variable.SetFieldName("invoiceextendeditemtax");
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
if (key == IdInvoiceExtendedItem) {
return ssENInvoiceExtendedItem;
}
if (key == IdInvoiceExtendedItemTax) {
return ssENInvoiceExtendedItemTax;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedItem.Key.AsGuid) {
return ssENInvoiceExtendedItem;
}
if (attributeKey == IdInvoiceExtendedItemTax.Key.AsGuid) {
return ssENInvoiceExtendedItemTax;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedItem.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItem));
ssENInvoiceExtendedItemTax.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedItemTax));
}
} // RC_25d357c844d16eb6579210aff3596f77
/// <summary>
/// RecordList type <code>InvoiceExtendedItemInvoiceExtendedItemTaxRecordList</code> that represents a
///  record list of <code>InvoiceExtendedItem, InvoiceExtendedItemTax</code>
/// </summary>
public partial class RL_203255693769e898ae6969552ca60cf6 : GenericRecordList<RC_25d357c844d16eb6579210aff3596f77>, IEnumerable, IEnumerator {

protected override RC_25d357c844d16eb6579210aff3596f77 GetElementDefaultValue() {
return new RC_25d357c844d16eb6579210aff3596f77();
}

public T[] ToArray<T>(Func<RC_25d357c844d16eb6579210aff3596f77, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_203255693769e898ae6969552ca60cf6 recordList, Func<RC_25d357c844d16eb6579210aff3596f77, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_203255693769e898ae6969552ca60cf6(RC_25d357c844d16eb6579210aff3596f77[] array) {
  RL_203255693769e898ae6969552ca60cf6 result = new RL_203255693769e898ae6969552ca60cf6();
result.InnerFromArray(array);
    return result;
}

public static RL_203255693769e898ae6969552ca60cf6 ToList<T>(T[] array, Func <T, RC_25d357c844d16eb6579210aff3596f77> converter) {
  RL_203255693769e898ae6969552ca60cf6 result = new RL_203255693769e898ae6969552ca60cf6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_203255693769e898ae6969552ca60cf6 FromRestList<T>(RestList<T> restList, Func <T, RC_25d357c844d16eb6579210aff3596f77> converter) {
  RL_203255693769e898ae6969552ca60cf6 result = new RL_203255693769e898ae6969552ca60cf6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_203255693769e898ae6969552ca60cf6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_25d357c844d16eb6579210aff3596f77> NewList() {
return new RL_203255693769e898ae6969552ca60cf6();
}


} // RL_203255693769e898ae6969552ca60cf6
}

