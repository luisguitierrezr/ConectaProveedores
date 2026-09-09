namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (7oWkuDokvEa8TyEp8JrPoQ)
///  <code>RC_bc05641ca90f5bed620129942456b69d</code> that represent
/// s <code>FolioOrderMainRegionRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioOrderMainRegionRecord
public partial struct RC_bc05641ca90f5bed620129942456b69d : ITypedRecord<RC_bc05641ca90f5bed620129942456b69d> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_bc05641ca90f5bed620129942456b69d() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(29,false);
    all[2] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENOrderMain.OptimizedAttributes = value[1];
    ssENRegion.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENOrderMain.OptimizedAttributes;
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
ssENFolio.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
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
public void ReadIM(RC_bc05641ca90f5bed620129942456b69d r) {
this = r;
}


public static bool operator == (RC_bc05641ca90f5bed620129942456b69d a, RC_bc05641ca90f5bed620129942456b69d b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_bc05641ca90f5bed620129942456b69d a, RC_bc05641ca90f5bed620129942456b69d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bc05641ca90f5bed620129942456b69d)) return false;
return (this == (RC_bc05641ca90f5bed620129942456b69d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_bc05641ca90f5bed620129942456b69d Duplicate() {
RC_bc05641ca90f5bed620129942456b69d t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdRegion) {
return ssENRegion;
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
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_bc05641ca90f5bed620129942456b69d
/// <summary>
/// RecordList type <code>FolioOrderMainRegionRecordList</code> that represents a record list of
///  <code>Folio, OrderMain, Region</code>
/// </summary>
public partial class RL_36d34882aca7a5992acfb2360fb5208c : GenericRecordList<RC_bc05641ca90f5bed620129942456b69d>, IEnumerable, IEnumerator {

protected override RC_bc05641ca90f5bed620129942456b69d GetElementDefaultValue() {
return new RC_bc05641ca90f5bed620129942456b69d();
}

public T[] ToArray<T>(Func<RC_bc05641ca90f5bed620129942456b69d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_36d34882aca7a5992acfb2360fb5208c recordList, Func<RC_bc05641ca90f5bed620129942456b69d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_36d34882aca7a5992acfb2360fb5208c(RC_bc05641ca90f5bed620129942456b69d[] array) {
  RL_36d34882aca7a5992acfb2360fb5208c result = new RL_36d34882aca7a5992acfb2360fb5208c();
result.InnerFromArray(array);
    return result;
}

public static RL_36d34882aca7a5992acfb2360fb5208c ToList<T>(T[] array, Func <T, RC_bc05641ca90f5bed620129942456b69d> converter) {
  RL_36d34882aca7a5992acfb2360fb5208c result = new RL_36d34882aca7a5992acfb2360fb5208c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_36d34882aca7a5992acfb2360fb5208c FromRestList<T>(RestList<T> restList, Func <T, RC_bc05641ca90f5bed620129942456b69d> converter) {
  RL_36d34882aca7a5992acfb2360fb5208c result = new RL_36d34882aca7a5992acfb2360fb5208c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_36d34882aca7a5992acfb2360fb5208c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(20,false);
def[1] = new BitArray(29,false);
def[2] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_bc05641ca90f5bed620129942456b69d> NewList() {
return new RL_36d34882aca7a5992acfb2360fb5208c();
}


} // RL_36d34882aca7a5992acfb2360fb5208c
}

