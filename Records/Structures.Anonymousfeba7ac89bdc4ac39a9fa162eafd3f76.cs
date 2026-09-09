namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yHq6_tybw0qan6Fi6v0_dg)
///  <code>RC_3336d2630e2646e00d0c2f5c3e5a01ea</code> that represent
/// s <code>InvoiceRequisitionRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceRequisitionRegionRecord
public partial struct RC_3336d2630e2646e00d0c2f5c3e5a01ea : ITypedRecord<RC_3336d2630e2646e00d0c2f5c3e5a01ea> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_3336d2630e2646e00d0c2f5c3e5a01ea() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(58,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENRequisition.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENRequisition.OptimizedAttributes;
    all[2] = ssENRegion.OptimizedAttributes;
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
public void ReadIM(RC_3336d2630e2646e00d0c2f5c3e5a01ea r) {
this = r;
}


public static bool operator == (RC_3336d2630e2646e00d0c2f5c3e5a01ea a, RC_3336d2630e2646e00d0c2f5c3e5a01ea b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_3336d2630e2646e00d0c2f5c3e5a01ea a, RC_3336d2630e2646e00d0c2f5c3e5a01ea b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3336d2630e2646e00d0c2f5c3e5a01ea)) return false;
return (this == (RC_3336d2630e2646e00d0c2f5c3e5a01ea)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_3336d2630e2646e00d0c2f5c3e5a01ea Duplicate() {
RC_3336d2630e2646e00d0c2f5c3e5a01ea t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdRequisition) {
return ssENRequisition;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_3336d2630e2646e00d0c2f5c3e5a01ea
/// <summary>
/// RecordList type <code>InvoiceRequisitionRegionRecordList</code> that represents a record list of
///  <code>Invoice, Requisition, Region</code>
/// </summary>
public partial class RL_c851528f2bd72df8d6fa01fc1d7dda59 : GenericRecordList<RC_3336d2630e2646e00d0c2f5c3e5a01ea>, IEnumerable, IEnumerator {

protected override RC_3336d2630e2646e00d0c2f5c3e5a01ea GetElementDefaultValue() {
return new RC_3336d2630e2646e00d0c2f5c3e5a01ea();
}

public T[] ToArray<T>(Func<RC_3336d2630e2646e00d0c2f5c3e5a01ea, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_c851528f2bd72df8d6fa01fc1d7dda59 recordList, Func<RC_3336d2630e2646e00d0c2f5c3e5a01ea, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_c851528f2bd72df8d6fa01fc1d7dda59(RC_3336d2630e2646e00d0c2f5c3e5a01ea[] array) {
  RL_c851528f2bd72df8d6fa01fc1d7dda59 result = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
result.InnerFromArray(array);
    return result;
}

public static RL_c851528f2bd72df8d6fa01fc1d7dda59 ToList<T>(T[] array, Func <T, RC_3336d2630e2646e00d0c2f5c3e5a01ea> converter) {
  RL_c851528f2bd72df8d6fa01fc1d7dda59 result = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_c851528f2bd72df8d6fa01fc1d7dda59 FromRestList<T>(RestList<T> restList, Func <T, RC_3336d2630e2646e00d0c2f5c3e5a01ea> converter) {
  RL_c851528f2bd72df8d6fa01fc1d7dda59 result = new RL_c851528f2bd72df8d6fa01fc1d7dda59();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_c851528f2bd72df8d6fa01fc1d7dda59() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(58,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3336d2630e2646e00d0c2f5c3e5a01ea> NewList() {
return new RL_c851528f2bd72df8d6fa01fc1d7dda59();
}


} // RL_c851528f2bd72df8d6fa01fc1d7dda59
}

