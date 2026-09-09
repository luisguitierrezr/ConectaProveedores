namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (muYo37jcL06xo8HGFnaAWw)
///  <code>RC_9f414d82ade67cb4131fecd8fda64580</code> that represent
/// s <code>InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord
public partial struct RC_9f414d82ade67cb4131fecd8fda64580 : ITypedRecord<RC_9f414d82ade67cb4131fecd8fda64580> {
internal static readonly GlobalObjectKey IdInvoiceApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*DCwQXPo08rxbZl5QxC0f2g");
internal static readonly GlobalObjectKey IdInvoiceId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FEYfrJuk3IJBHUZHMkXWrA");
internal static readonly GlobalObjectKey IdInvoiceName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T84HGhH0o_rkUTQc03fT6A");
internal static readonly GlobalObjectKey IdIsAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ox99coeuOnxY61pNuNVXMQ");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");

public long ssInvoiceApprovalLevelId;

public long ssInvoiceId;

public string ssInvoiceName;

public bool ssIsAccounting;

public bool ssIsSelected;


public BitArray OptimizedAttributes;

public RC_9f414d82ade67cb4131fecd8fda64580() {
OptimizedAttributes = null;
ssInvoiceApprovalLevelId = 0L;
ssInvoiceId = 0L;
ssInvoiceName = "";
ssIsAccounting = false;
ssIsSelected = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssInvoiceApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord.InvoiceApprovalLevelId", 0L);
ssInvoiceId = r.ReadEntityReferenceLongInteger(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord.InvoiceId", 0L);
ssInvoiceName = r.ReadText(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord.InvoiceName", "");
ssIsAccounting = r.ReadBoolean(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord.IsAccounting", false);
ssIsSelected = r.ReadBoolean(index++, "InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecord.IsSelected", false);
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
public void ReadIM(RC_9f414d82ade67cb4131fecd8fda64580 r) {
this = r;
}


public static bool operator == (RC_9f414d82ade67cb4131fecd8fda64580 a, RC_9f414d82ade67cb4131fecd8fda64580 b) {
if (a.ssInvoiceApprovalLevelId != b.ssInvoiceApprovalLevelId) return false;
if (a.ssInvoiceId != b.ssInvoiceId) return false;
if (a.ssInvoiceName != b.ssInvoiceName) return false;
if (a.ssIsAccounting != b.ssIsAccounting) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
return true;
}

public static bool operator != (RC_9f414d82ade67cb4131fecd8fda64580 a, RC_9f414d82ade67cb4131fecd8fda64580 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9f414d82ade67cb4131fecd8fda64580)) return false;
return (this == (RC_9f414d82ade67cb4131fecd8fda64580)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssInvoiceApprovalLevelId.GetHashCode()
 ^ ssInvoiceId.GetHashCode()
 ^ ssInvoiceName.GetHashCode()
 ^ ssIsAccounting.GetHashCode()
 ^ ssIsSelected.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_9f414d82ade67cb4131fecd8fda64580 Duplicate() {
RC_9f414d82ade67cb4131fecd8fda64580 t;
t.ssInvoiceApprovalLevelId = this.ssInvoiceApprovalLevelId;
t.ssInvoiceId = this.ssInvoiceId;
t.ssInvoiceName = this.ssInvoiceName;
t.ssIsAccounting = this.ssIsAccounting;
t.ssIsSelected = this.ssIsSelected;
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
if (head == "invoiceapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceApprovalLevelId")) variable.Value = ssInvoiceApprovalLevelId; else variable.Optimized = true;
} else if (head == "invoiceid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceId")) variable.Value = ssInvoiceId; else variable.Optimized = true;
} else if (head == "invoicename") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceName")) variable.Value = ssInvoiceName; else variable.Optimized = true;
} else if (head == "isaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAccounting")) variable.Value = ssIsAccounting; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdInvoiceApprovalLevelId) {
return ssInvoiceApprovalLevelId;
}
if (key == IdInvoiceId) {
return ssInvoiceId;
}
if (key == IdInvoiceName) {
return ssInvoiceName;
}
if (key == IdIsAccounting) {
return ssIsAccounting;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceApprovalLevelId.Key.AsGuid) {
return ssInvoiceApprovalLevelId;
}
if (attributeKey == IdInvoiceId.Key.AsGuid) {
return ssInvoiceId;
}
if (attributeKey == IdInvoiceName.Key.AsGuid) {
return ssInvoiceName;
}
if (attributeKey == IdIsAccounting.Key.AsGuid) {
return ssIsAccounting;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssInvoiceApprovalLevelId = (long) other.AttributeGet(IdInvoiceApprovalLevelId);
ssInvoiceId = (long) other.AttributeGet(IdInvoiceId);
ssInvoiceName = (string) other.AttributeGet(IdInvoiceName);
ssIsAccounting = (bool) other.AttributeGet(IdIsAccounting);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
}
} // RC_9f414d82ade67cb4131fecd8fda64580
/// <summary>
/// RecordList type
///  <code>InvoiceApprovalLevelIdInvoiceIdInvoiceNameIsAccountingIsSelectedRecordList</code> tha
/// t represents a record list of <code>InvoiceApprovalLevelIdentifier, InvoiceIdentifier, Text,
///  Boolean, Boolean</code>
/// </summary>
public partial class RL_8c69b09c6d811e27e13cdf810a622fb2 : GenericRecordList<RC_9f414d82ade67cb4131fecd8fda64580>, IEnumerable, IEnumerator {

protected override RC_9f414d82ade67cb4131fecd8fda64580 GetElementDefaultValue() {
return new RC_9f414d82ade67cb4131fecd8fda64580();
}

public T[] ToArray<T>(Func<RC_9f414d82ade67cb4131fecd8fda64580, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_8c69b09c6d811e27e13cdf810a622fb2 recordList, Func<RC_9f414d82ade67cb4131fecd8fda64580, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_8c69b09c6d811e27e13cdf810a622fb2(RC_9f414d82ade67cb4131fecd8fda64580[] array) {
  RL_8c69b09c6d811e27e13cdf810a622fb2 result = new RL_8c69b09c6d811e27e13cdf810a622fb2();
result.InnerFromArray(array);
    return result;
}

public static RL_8c69b09c6d811e27e13cdf810a622fb2 ToList<T>(T[] array, Func <T, RC_9f414d82ade67cb4131fecd8fda64580> converter) {
  RL_8c69b09c6d811e27e13cdf810a622fb2 result = new RL_8c69b09c6d811e27e13cdf810a622fb2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_8c69b09c6d811e27e13cdf810a622fb2 FromRestList<T>(RestList<T> restList, Func <T, RC_9f414d82ade67cb4131fecd8fda64580> converter) {
  RL_8c69b09c6d811e27e13cdf810a622fb2 result = new RL_8c69b09c6d811e27e13cdf810a622fb2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_8c69b09c6d811e27e13cdf810a622fb2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9f414d82ade67cb4131fecd8fda64580> NewList() {
return new RL_8c69b09c6d811e27e13cdf810a622fb2();
}


} // RL_8c69b09c6d811e27e13cdf810a622fb2
}

