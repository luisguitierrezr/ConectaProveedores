namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (FUZRLjCM50+VsJxayz6ZZw)
///  <code>RC_dc377962308205a06a34e4c0881035f7</code> that represent
/// s <code>InvoiceRequisitionInvoicePolizaRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceRequisitionInvoicePolizaRecord
public partial struct RC_dc377962308205a06a34e4c0881035f7 : ITypedRecord<RC_dc377962308205a06a34e4c0881035f7> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoicePoliza = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FGf9FFyQZ8GAODzC2obuDQ");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord ssENInvoicePoliza;


public BitArray OptimizedAttributes;

public RC_dc377962308205a06a34e4c0881035f7() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoicePoliza = new EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(9,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoicePoliza.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENInvoicePoliza.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENInvoicePoliza.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENInvoicePoliza.Read( r, ref index);
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
public void ReadIM(RC_dc377962308205a06a34e4c0881035f7 r) {
this = r;
}


public static bool operator == (RC_dc377962308205a06a34e4c0881035f7 a, RC_dc377962308205a06a34e4c0881035f7 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoicePoliza != b.ssENInvoicePoliza) return false;
return true;
}

public static bool operator != (RC_dc377962308205a06a34e4c0881035f7 a, RC_dc377962308205a06a34e4c0881035f7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_dc377962308205a06a34e4c0881035f7)) return false;
return (this == (RC_dc377962308205a06a34e4c0881035f7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoicePoliza.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoicePoliza.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoicePoliza.InternalRecursiveSave();
}


public RC_dc377962308205a06a34e4c0881035f7 Duplicate() {
RC_dc377962308205a06a34e4c0881035f7 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoicePoliza = (EN_40f7c2dd79fcf6f1dd71369cb12f9d79EntityRecord)this.ssENInvoicePoliza.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoicepoliza") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoicePoliza")) variable.Value = ssENInvoicePoliza; else variable.Optimized = true;
variable.SetFieldName("invoicepoliza");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoicePoliza) {
return ssENInvoicePoliza;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoicePoliza.Key.AsGuid) {
return ssENInvoicePoliza;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoicePoliza.FillFromOther((IRecord) other.AttributeGet(IdInvoicePoliza));
}
} // RC_dc377962308205a06a34e4c0881035f7
/// <summary>
/// RecordList type <code>InvoiceRequisitionInvoicePolizaRecordList</code> that represents a record
///  list of <code>Invoice, Requisition, InvoicePoliza</code>
/// </summary>
public partial class RL_f047dac638a0be52385038d9c0d00821 : GenericRecordList<RC_dc377962308205a06a34e4c0881035f7>, IEnumerable, IEnumerator {

protected override RC_dc377962308205a06a34e4c0881035f7 GetElementDefaultValue() {
return new RC_dc377962308205a06a34e4c0881035f7();
}

public T[] ToArray<T>(Func<RC_dc377962308205a06a34e4c0881035f7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f047dac638a0be52385038d9c0d00821 recordList, Func<RC_dc377962308205a06a34e4c0881035f7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f047dac638a0be52385038d9c0d00821(RC_dc377962308205a06a34e4c0881035f7[] array) {
  RL_f047dac638a0be52385038d9c0d00821 result = new RL_f047dac638a0be52385038d9c0d00821();
result.InnerFromArray(array);
    return result;
}

public static RL_f047dac638a0be52385038d9c0d00821 ToList<T>(T[] array, Func <T, RC_dc377962308205a06a34e4c0881035f7> converter) {
  RL_f047dac638a0be52385038d9c0d00821 result = new RL_f047dac638a0be52385038d9c0d00821();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f047dac638a0be52385038d9c0d00821 FromRestList<T>(RestList<T> restList, Func <T, RC_dc377962308205a06a34e4c0881035f7> converter) {
  RL_f047dac638a0be52385038d9c0d00821 result = new RL_f047dac638a0be52385038d9c0d00821();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f047dac638a0be52385038d9c0d00821() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(9,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_dc377962308205a06a34e4c0881035f7> NewList() {
return new RL_f047dac638a0be52385038d9c0d00821();
}


} // RL_f047dac638a0be52385038d9c0d00821
}

