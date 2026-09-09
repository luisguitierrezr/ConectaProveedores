namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4LGGdUSFxUq8zD8xlJizCw)
///  <code>RC_d80dcf5f9effb79b8ba59dd1971d484d</code> that represents <code>FolioOrderMainRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: FolioOrderMainRecord
public partial struct RC_d80dcf5f9effb79b8ba59dd1971d484d : ITypedRecord<RC_d80dcf5f9effb79b8ba59dd1971d484d> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;


public BitArray OptimizedAttributes;

public RC_d80dcf5f9effb79b8ba59dd1971d484d() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(29,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_d80dcf5f9effb79b8ba59dd1971d484d r) {
this = r;
}


public static bool operator == (RC_d80dcf5f9effb79b8ba59dd1971d484d a, RC_d80dcf5f9effb79b8ba59dd1971d484d b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
return true;
}

public static bool operator != (RC_d80dcf5f9effb79b8ba59dd1971d484d a, RC_d80dcf5f9effb79b8ba59dd1971d484d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d80dcf5f9effb79b8ba59dd1971d484d)) return false;
return (this == (RC_d80dcf5f9effb79b8ba59dd1971d484d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
}


public RC_d80dcf5f9effb79b8ba59dd1971d484d Duplicate() {
RC_d80dcf5f9effb79b8ba59dd1971d484d t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
}
} // RC_d80dcf5f9effb79b8ba59dd1971d484d
/// <summary>
/// RecordList type <code>FolioOrderMainRecordList</code> that represents a record list of <code>Folio,
///  OrderMain</code>
/// </summary>
public partial class RL_d93cbaf98e8c7bf91c01ba8ed183bc42 : GenericRecordList<RC_d80dcf5f9effb79b8ba59dd1971d484d>, IEnumerable, IEnumerator {

protected override RC_d80dcf5f9effb79b8ba59dd1971d484d GetElementDefaultValue() {
return new RC_d80dcf5f9effb79b8ba59dd1971d484d();
}

public T[] ToArray<T>(Func<RC_d80dcf5f9effb79b8ba59dd1971d484d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d93cbaf98e8c7bf91c01ba8ed183bc42 recordList, Func<RC_d80dcf5f9effb79b8ba59dd1971d484d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d93cbaf98e8c7bf91c01ba8ed183bc42(RC_d80dcf5f9effb79b8ba59dd1971d484d[] array) {
  RL_d93cbaf98e8c7bf91c01ba8ed183bc42 result = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
result.InnerFromArray(array);
    return result;
}

public static RL_d93cbaf98e8c7bf91c01ba8ed183bc42 ToList<T>(T[] array, Func <T, RC_d80dcf5f9effb79b8ba59dd1971d484d> converter) {
  RL_d93cbaf98e8c7bf91c01ba8ed183bc42 result = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d93cbaf98e8c7bf91c01ba8ed183bc42 FromRestList<T>(RestList<T> restList, Func <T, RC_d80dcf5f9effb79b8ba59dd1971d484d> converter) {
  RL_d93cbaf98e8c7bf91c01ba8ed183bc42 result = new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d93cbaf98e8c7bf91c01ba8ed183bc42() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(20,false);
def[1] = new BitArray(29,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d80dcf5f9effb79b8ba59dd1971d484d> NewList() {
return new RL_d93cbaf98e8c7bf91c01ba8ed183bc42();
}


} // RL_d93cbaf98e8c7bf91c01ba8ed183bc42
}

