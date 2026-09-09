namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (SXzFI5VjhE2fbLI5UhCc1w)
///  <code>RC_b64b49f04ca283a60f06aecf635b2100</code> that represent
/// s <code>OrdersConceptOrderDetailAllFilesRecord</code> <p>Description: </p>
/// </summary>
// Name: OrdersConceptOrderDetailAllFilesRecord
public partial struct RC_b64b49f04ca283a60f06aecf635b2100 : ITypedRecord<RC_b64b49f04ca283a60f06aecf635b2100> {
internal static readonly GlobalObjectKey IdOrdersConcept = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jSiNhbQd0FHJg611iV2lWQ");
internal static readonly GlobalObjectKey IdOrderDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*__4Pf33sZAjriFX+joc3Qw");
internal static readonly GlobalObjectKey IdAllFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*UHCUxwYcw4J3BiayA7MWDw");

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrdersConcept;

public EN_26f696e758428762fc617e811634d15dEntityRecord ssENOrderDetail;

public RL_3d745491e03d6d19ccc0e1b33a371ccc ssRLAllFiles;


public BitArray OptimizedAttributes;

public RC_b64b49f04ca283a60f06aecf635b2100() {
OptimizedAttributes = null;
ssENOrdersConcept = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENOrderDetail = new EN_26f696e758428762fc617e811634d15dEntityRecord();
ssRLAllFiles = new RL_3d745491e03d6d19ccc0e1b33a371ccc();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(29,false);
    all[1] = new BitArray(39,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrdersConcept.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderDetail.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENOrdersConcept.OptimizedAttributes = value[0];
    ssENOrderDetail.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENOrdersConcept.OptimizedAttributes;
    all[1] = ssENOrderDetail.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrdersConcept.Read( r, ref index);
ssENOrderDetail.Read( r, ref index);
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
public void ReadIM(RC_b64b49f04ca283a60f06aecf635b2100 r) {
this = r;
}


public static bool operator == (RC_b64b49f04ca283a60f06aecf635b2100 a, RC_b64b49f04ca283a60f06aecf635b2100 b) {
if (a.ssENOrdersConcept != b.ssENOrdersConcept) return false;
if (a.ssENOrderDetail != b.ssENOrderDetail) return false;
if (a.ssRLAllFiles != b.ssRLAllFiles) return false;
return true;
}

public static bool operator != (RC_b64b49f04ca283a60f06aecf635b2100 a, RC_b64b49f04ca283a60f06aecf635b2100 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b64b49f04ca283a60f06aecf635b2100)) return false;
return (this == (RC_b64b49f04ca283a60f06aecf635b2100)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrdersConcept.GetHashCode()
 ^ ssENOrderDetail.GetHashCode()
 ^ ssRLAllFiles.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrdersConcept.RecursiveReset();
ssENOrderDetail.RecursiveReset();
ssRLAllFiles.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrdersConcept.InternalRecursiveSave();
ssENOrderDetail.InternalRecursiveSave();
ssRLAllFiles.InternalRecursiveSave();
}


public RC_b64b49f04ca283a60f06aecf635b2100 Duplicate() {
RC_b64b49f04ca283a60f06aecf635b2100 t;
t.ssENOrdersConcept = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrdersConcept.Duplicate();
t.ssENOrderDetail = (EN_26f696e758428762fc617e811634d15dEntityRecord)this.ssENOrderDetail.Duplicate();
t.ssRLAllFiles = (RL_3d745491e03d6d19ccc0e1b33a371ccc)this.ssRLAllFiles.Duplicate();
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
if (head == "ordersconcept") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersConcept")) variable.Value = ssENOrdersConcept; else variable.Optimized = true;
variable.SetFieldName("ordersconcept");
} else if (head == "orderdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderDetail")) variable.Value = ssENOrderDetail; else variable.Optimized = true;
variable.SetFieldName("orderdetail");
} else if (head == "allfiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AllFiles")) variable.Value = ssRLAllFiles; else variable.Optimized = true;
variable.SetFieldName("allfiles");
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
if (key == IdOrdersConcept) {
return ssENOrdersConcept;
}
if (key == IdOrderDetail) {
return ssENOrderDetail;
}
if (key == IdAllFiles) {
return ssRLAllFiles;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrdersConcept.Key.AsGuid) {
return ssENOrdersConcept;
}
if (attributeKey == IdOrderDetail.Key.AsGuid) {
return ssENOrderDetail;
}
if (attributeKey == IdAllFiles.Key.AsGuid) {
return ssRLAllFiles;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrdersConcept.FillFromOther((IRecord) other.AttributeGet(IdOrdersConcept));
ssENOrderDetail.FillFromOther((IRecord) other.AttributeGet(IdOrderDetail));
ssRLAllFiles = new RL_3d745491e03d6d19ccc0e1b33a371ccc();
ssRLAllFiles.FillFromOther((IOSList) other.AttributeGet(IdAllFiles));
}
} // RC_b64b49f04ca283a60f06aecf635b2100
/// <summary>
/// RecordList type <code>OrdersConceptOrderDetailAllFilesRecordList</code> that represents a record
///  list of <code>OrderMain, OrderDetail, OrderFileTypesStructList</code>
/// </summary>
public partial class RL_9de9e13e6af34501b6eef0cfb59ee111 : GenericRecordList<RC_b64b49f04ca283a60f06aecf635b2100>, IEnumerable, IEnumerator {

protected override RC_b64b49f04ca283a60f06aecf635b2100 GetElementDefaultValue() {
return new RC_b64b49f04ca283a60f06aecf635b2100();
}

public T[] ToArray<T>(Func<RC_b64b49f04ca283a60f06aecf635b2100, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9de9e13e6af34501b6eef0cfb59ee111 recordList, Func<RC_b64b49f04ca283a60f06aecf635b2100, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9de9e13e6af34501b6eef0cfb59ee111(RC_b64b49f04ca283a60f06aecf635b2100[] array) {
  RL_9de9e13e6af34501b6eef0cfb59ee111 result = new RL_9de9e13e6af34501b6eef0cfb59ee111();
result.InnerFromArray(array);
    return result;
}

public static RL_9de9e13e6af34501b6eef0cfb59ee111 ToList<T>(T[] array, Func <T, RC_b64b49f04ca283a60f06aecf635b2100> converter) {
  RL_9de9e13e6af34501b6eef0cfb59ee111 result = new RL_9de9e13e6af34501b6eef0cfb59ee111();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9de9e13e6af34501b6eef0cfb59ee111 FromRestList<T>(RestList<T> restList, Func <T, RC_b64b49f04ca283a60f06aecf635b2100> converter) {
  RL_9de9e13e6af34501b6eef0cfb59ee111 result = new RL_9de9e13e6af34501b6eef0cfb59ee111();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9de9e13e6af34501b6eef0cfb59ee111() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(29,false);
def[1] = new BitArray(39,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b64b49f04ca283a60f06aecf635b2100> NewList() {
return new RL_9de9e13e6af34501b6eef0cfb59ee111();
}


} // RL_9de9e13e6af34501b6eef0cfb59ee111
}

